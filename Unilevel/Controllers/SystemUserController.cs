using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Unilevel.DTOs;
using Unilevel.Services;

namespace Unilevel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SystemUserController : ControllerBase
    {
        private readonly SystemUserService _systemUserService;

        public SystemUserController(SystemUserService systemUserService)
        {
            _systemUserService = systemUserService;
        }


        // lay danh sach user co trong database (bao gom ca admin va owner )
        [HttpGet("list")]
        public async Task<IActionResult> ListAllUsers()
        {
            var users = await _systemUserService.ListAllUsersAsync();
            return Ok(users);
        }


        // tao user moi
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] Account account)  
        {
          
            var result = await _systemUserService.CreateUserAsync(account); 
            if (result.Succeeded)
            {
                return Ok("User created successfully.");
            }
            return BadRequest(result.Errors);
        }

        // lay user theo id
        //[Authorize(Roles = "Owner,Administrator")]
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetUserById(string id)
        //{
        //    var user = await _systemUserService.GetUserByIdAsync(id);
        //    if (user == null)
        //    {
        //        return NotFound("User not found.");
        //    }
        //    return Ok(user);
        //}


        // Update user information
        [Authorize(Roles = "Owner,Administrator")]
        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser([FromBody] Account user)
        {
            var result = await _systemUserService.UpdateUserAsync(Guid.Parse(user.Id), user);

            if (result.Succeeded)
            {
                return Ok("User updated successfully.");
            }

            return BadRequest(result.Errors);
        }


        // Xoa user
        [Authorize(Roles = "Owner,Administrator")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var result = await _systemUserService.DeleteUserAsync(id);
            if (result.Succeeded)
            {
                return Ok("User deleted successfully.");
            }
            return BadRequest(result.Errors);
        }


        // Tim kiem
        [Authorize(Roles = "Owner,Administrator")]
        [HttpGet("search")]
        public async Task<IActionResult> SearchUsers(string searchTerm)
        {
            var users = await _systemUserService.SearchUsersAsync(searchTerm);
            return Ok(users);
        }


        // Reset mat khau ( danh cho trang admin)
        [Authorize(Roles = "Owner,Administrator")]
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(string userId)
        {
            var result = await _systemUserService.ResetPasswordAsync(userId);
            if (result.Succeeded)
            {
                return Ok("Password reset successfully.");
            }
            return BadRequest(result.Errors);
        }


        [HttpPost("import")]
        public async Task<IActionResult> ImportUsers(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Invalid file.");
            }

            var extension = Path.GetExtension(file.FileName).ToLower();
            if (extension != ".csv" && extension != ".xlsx")
            {
                return BadRequest("Only CSV or Excel files are supported.");
            }

            try
            {
                Stream processedStream;

                // Call the service to handle CSV to Excel conversion
                if (extension == ".csv")
                {
                    processedStream = _systemUserService.ConvertCsvToExcel(file.OpenReadStream());
                }
                else
                {
                    processedStream = file.OpenReadStream();
                }

                // Process the Excel file
                var (added, updated, errors, errorLogs) = await _systemUserService.ImportUsersFromExcelAsync(processedStream);

                return Ok(new
                {
                    AddedUsers = added,
                    UpdatedUsers = updated,
                    ErrorCount = errors,
                    ErrorLogs = errorLogs // Return the errors directly in the response
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }




        [HttpGet("export")]
        public async Task<IActionResult> ExportUsers()
        {
            var fileContent = await _systemUserService.ExportUsersToExcelAsync();
            return File(fileContent, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Users.xlsx");
        }

    }


}
