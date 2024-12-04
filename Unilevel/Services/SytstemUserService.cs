using ClosedXML.Excel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Unilevel.DTOs;
using Unilevel.Models;

namespace Unilevel.Services
{
    public class SystemUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly AppDbContext _appDbContext;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _configuration;
        public SystemUserService(UserManager<User> userManager, AppDbContext appDbContext, RoleManager<Role> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _appDbContext = appDbContext;
            _roleManager = roleManager;
            _configuration = configuration;
        }


        // Liet ke tat ca nguoi dung
        public async Task<List<Account>> ListAllUsersAsync()
        {
            var users = await (from user in _userManager.Users
                                        from userRole in _appDbContext.UserRoles.Where(ur => ur.UserId == user.Id)
                                        join role in _appDbContext.Roles on userRole.RoleId equals role.Id
                                        select new Account
                                        {
                                            Id = user.Id.ToString(),
                                            UserName = user.UserName,
                                            PhoneNumber = user.PhoneNumber,
                                            Email = user.Email,
                                            Address = user.Address,
                                            Role = role.Name,
                                            AreaId  = user.AreaId,
                                            JoinDate = user.JoinDate,
                                            IsActive = user.IsActive,
                                            Reporter = user.Reporter,
                                        }).ToListAsync();

            return users;
        }


        // tao nguoi dung moi
        public async Task<IdentityResult> CreateUserAsync(Account account)
        {

            var user = new User
            {
                UserName = account.UserName,
                Email = account.Email,
                PhoneNumber = account.PhoneNumber,
                Address = account.Address,
                AreaId = account.AreaId,
                JoinDate = account.JoinDate,
                IsActive = account.IsActive,
                Reporter = account.Reporter ?? null,
            };

            
            var result = await _userManager.CreateAsync(user, account.Password); 
            if (result.Succeeded)
            {
                
                var role = account.Role ; 
                if (await _roleManager.RoleExistsAsync(role))
                {
                    await _userManager.AddToRoleAsync(user, role);
                }
                else
                {
                   
                    throw new ArgumentException($"Role '{role}' does not exist.");
                }
            }

            return result;
        }


        //doc thong tin nguoi dung qua Id
        //public async Task<Account> GetUserByIdAsync(string userId)
        //{
        //    var user = await _userManager.FindByIdAsync(userId);
        //    if (user == null) return null;

        //    var roles = await _userManager.GetRolesAsync(user);
        //    return new Account
        //    {
        //        UserName = user.UserName,
        //        PhoneNumber = user.PhoneNumber,
        //        Email = user.Email,
        //        Address = user.Address,
        //        Role = roles.FirstOrDefault(), // Assume single role for simplicity
        //        Area = user.Area,
        //        JoinDate = user.JoinDate
        //    };
        //}


        // Cap nhat thong tin nguoi dung
        public async Task<IdentityResult> UpdateUserAsync(Guid userId, Account account)
        {

            string UserIdStringConvert = userId.ToString();
            var user = await _userManager.FindByIdAsync(UserIdStringConvert);
            if (user == null) throw new ArgumentException("User not found.");

            if (!await IsValidReporterAsync(account.Reporter))
            {
                throw new ArgumentException("Invalid Reporter: User does not exist.");
            }

            user.UserName = account.UserName;
            user.PhoneNumber = account.PhoneNumber;
            user.Email = account.Email;
            user.Address = account.Address;
            user.AreaId = account.AreaId;
            user.JoinDate = account.JoinDate;
            user.IsActive = account.IsActive;
            user.Reporter = account.Reporter;

            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded && account.Role != null)
            {
                var currentRoles = await _userManager.GetRolesAsync(user);
                if (!currentRoles.Contains(account.Role))
                {
                    await _userManager.RemoveFromRolesAsync(user, currentRoles);
                    await _userManager.AddToRoleAsync(user, account.Role);
                }
            }

            return result;
        }


        // Xoa nguoi dung 
        public async Task<IdentityResult> DeleteUserAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null) throw new ArgumentException("User not found.");

            return await _userManager.DeleteAsync(user);
        }

        // Tim kiem nguoi dung theo thong tin 
        public async Task<List<Account>> SearchUsersAsync(string searchTerm)
        {
            var users = await _userManager.Users
                .Where(user => user.UserName.Contains(searchTerm) || user.Email.Contains(searchTerm) ||
                        user.Address.Contains(searchTerm) || user.AreaId.Contains(searchTerm) || 
                        user.PhoneNumber.Contains(searchTerm))
                .ToListAsync();

            var userAccounts = new List<Account>();
            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                userAccounts.Add(new Account
                {
                    UserName = user.UserName,
                    PhoneNumber = user.PhoneNumber,
                    Email = user.Email,
                    Address = user.Address,
                    Role = roles.FirstOrDefault(),
                    AreaId = user.AreaId,
                    JoinDate = user.JoinDate
                });
            }

            return userAccounts;
        }

        // Đat lai mat khau 
        public async Task<IdentityResult> ResetPasswordAsync(string userId)
        {
            var passwordSetting = _configuration.GetSection("PasswordDefault");
            string newPassword = passwordSetting["Pass"];
            var user = await _userManager.FindByIdAsync(userId);

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            return await _userManager.ResetPasswordAsync(user, token, newPassword);
        }


        //check xem reportter co trong User khong
        private async Task<bool> IsValidReporterAsync(string reporterUserName)
        {
            if (string.IsNullOrEmpty(reporterUserName))
            {
                return false;
            }

            // Check tham so dau vao
            var reporterUser = await _userManager.FindByNameAsync(reporterUserName);
            return reporterUser != null;
        }


        //Ham import user bang excel
        public async Task<(int added, int updated, int errors, List<string> errorLogs)> ImportUsersFromExcelAsync(Stream fileStream)
        {
            int added = 0, updated = 0, errors = 0;
            var errorLogs = new List<string>();

            using (var workbook = new XLWorkbook(fileStream))
            {
                var worksheet = workbook.Worksheet(1);
                var rows = worksheet.RowsUsed();

                foreach (var row in rows.Skip(1)) // Bo dong dau tien ( dong tieu de )
                {
                    try
                    {
                        string userName = row.Cell(1).GetValue<string>();
                        string email = row.Cell(2).GetValue<string>();
                        string phoneNumber = row.Cell(3).GetValue<string>();
                        string address = row.Cell(4).GetValue<string>();
                        string area = row.Cell(5).GetValue<string>();
                        string role = row.Cell(7).GetValue<string>();

                        if (!DateTime.TryParse(row.Cell(6).GetValue<string>(), out var joinDate))
                            throw new Exception("Dinh dang ngay thang khong dung");

                        if (!bool.TryParse(row.Cell(8).GetValue<string>(), out var isActive))
                            throw new Exception("Dinh danh boolean khong dung");

                        // Check Role 
                        if (!string.IsNullOrEmpty(role))
                        {
                            var roleExists = await _roleManager.RoleExistsAsync(role); //Check role
                            if (!roleExists)
                                throw new Exception($"Role {role} does not exist.");
                        }

                        // Tim user
                        var existingUser = await _userManager.FindByNameAsync(userName);

                        if (existingUser == null)
                        {
                            // Tao nguoi dung moi
                            var newUser = new User
                            {
                                UserName = userName,
                                Email = email,
                                PhoneNumber = phoneNumber,
                                Address = address,
                                AreaId = area,
                                JoinDate = joinDate,
                                IsActive = isActive
                            };

                            var passwordSetting = _configuration.GetSection("PasswordDefault");
                            string newPassword = passwordSetting["Pass"];
                            var result = await _userManager.CreateAsync(newUser, newPassword); 

                            if (!result.Succeeded)
                                throw new Exception($"Failed to create user '{userName}': {string.Join(", ", result.Errors.Select(e => e.Description))}");

                            // Gan Role
                            if (!string.IsNullOrEmpty(role))
                            {
                                var roleResult = await _userManager.AddToRoleAsync(newUser, role);
                                if (!roleResult.Succeeded)
                                    throw new Exception($"Failed to assign role {role} to user {userName}");
                            }

                            added++;
                        }
                        else
                        {
                            // Cap nhat nguoi dung hien co
                            existingUser.Email = email;
                            existingUser.PhoneNumber = phoneNumber;
                            existingUser.Address = address;
                            existingUser.AreaId = area;
                            existingUser.JoinDate = joinDate;
                            existingUser.IsActive = isActive;

                            var updateResult = await _userManager.UpdateAsync(existingUser);
                            if (!updateResult.Succeeded)
                                throw new Exception($"Failed to update user '{userName}': {string.Join(", ", updateResult.Errors.Select(e => e.Description))}");

                            updated++;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Bo qua hang hien tai neu co loi
                        errors++;
                        errorLogs.Add($"Error processing row {row.RowNumber()}: {ex.Message}");
                    }
                }
            }

            return (added, updated, errors, errorLogs);
        }


        // Ham convert tu csv sang excel
        public Stream ConvertCsvToExcel(Stream csvStream)
        {
            using (var reader = new StreamReader(csvStream))
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    int currentRow = 1;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line?.Split(',');

                        if (values == null) continue;

                        for (int i = 0; i < values.Length; i++)
                        {
                            worksheet.Cell(currentRow, i + 1).Value = values[i];
                        }

                        currentRow++;
                    }

                    var excelStream = new MemoryStream();
                    workbook.SaveAs(excelStream);
                    excelStream.Position = 0; 
                    return excelStream;
                }
            }
        }


        // Ham xuat excel
        public async Task<byte[]> ExportUsersToExcelAsync()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Users");
                
                worksheet.Cell(1, 1).Value = "UserName";
                worksheet.Cell(1, 2).Value = "Email";
                worksheet.Cell(1, 3).Value = "PhoneNumber";
                worksheet.Cell(1, 4).Value = "Address";
                worksheet.Cell(1, 5).Value = "Area";
                worksheet.Cell(1, 6).Value = "JoinDate";
                worksheet.Cell(1, 7).Value = "Role";
                worksheet.Cell(1, 8).Value = "IsActive";

                var users = await _userManager.Users.ToListAsync();
                int row = 2;

                foreach (var user in users)
                {
                    bool? isActive = user.IsActive;
                    var roles = await _userManager.GetRolesAsync(user);
                    worksheet.Cell(row, 1).Value = user.UserName;
                    worksheet.Cell(row, 2).Value = user.Email;
                    worksheet.Cell(row, 3).Value = user.PhoneNumber;
                    worksheet.Cell(row, 4).Value = user.Address;
                    worksheet.Cell(row, 5).Value = user.AreaId;
                    worksheet.Cell(row, 6).Value = user.JoinDate;
                    worksheet.Cell(row, 7).Value = roles.FirstOrDefault();
                    worksheet.Cell(row, 8).Value = isActive ?? false;
                    row++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    return stream.ToArray();
                }
            }
        }
    }


}
