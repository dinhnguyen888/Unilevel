using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Unilevel.DTOs;

namespace Unilevel.Services
{
    public class SystemUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly AppDbContext _appDbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        public SystemUserService(UserManager<User> userManager, AppDbContext appDbContext, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
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
                                            Area = user.Area,
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
                Area = account.Area,
                JoinDate = account.JoinDate,
                IsActive = account.IsActive,
                Reporter = account.Reporter ?? null,
            };

            
            var result = await _userManager.CreateAsync(user, account.Password); 
            if (result.Succeeded)
            {
                
                var role = account.Role ?? "Guest"; 
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
            user.Area = account.Area;
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
                        user.Address.Contains(searchTerm) || user.Area.Contains(searchTerm) || 
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
                    Area = user.Area,
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
            //if (user == null) throw new ArgumentException("User not found.");

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

            // Kiểm tra xem user có tồn tại với UserName là reporterUserName không
            var reporterUser = await _userManager.FindByNameAsync(reporterUserName);
            return reporterUser != null;
        }
    }

}
