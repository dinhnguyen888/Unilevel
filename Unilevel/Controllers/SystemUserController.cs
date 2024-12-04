using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Unilevel.DTOs;
using Unilevel.Services;

namespace Unilevel.Controllers
{
    /// <summary>
    /// API quan ly nguoi dung trong he thong.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class SystemUserController : ControllerBase
    {
        private readonly SystemUserService _systemUserService;

        public SystemUserController(SystemUserService systemUserService)
        {
            _systemUserService = systemUserService;
        }

        /// <summary>
        /// Lay danh sach tat ca nguoi dung trong he thong.
        /// </summary>
        /// <returns>Danh sach nguoi dung.</returns>
        [CustomAuthorize("Can View Users", 1)]
        [HttpGet("list")]
        public async Task<IActionResult> ListAllUsers()
        {
            var users = await _systemUserService.ListAllUsersAsync();
            return Ok(users);
        }

        /// <summary>
        /// Tao nguoi dung moi.
        /// </summary>
        /// <param name="account">Thong tin nguoi dung moi.</param>
        /// <returns>Thong bao ket qua tao nguoi dung.</returns>
        [GroupRoleAuthorize(1)]
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] Account account)
        {
            var result = await _systemUserService.CreateUserAsync(account);
            if (result.Succeeded)
            {
                return Ok("Tao nguoi dung thanh cong.");
            }
            return BadRequest(result.Errors);
        }

        /// <summary>
        /// Cap nhat thong tin nguoi dung.
        /// </summary>
        /// <param name="user">Thong tin nguoi dung cap nhat.</param>
        /// <returns>Thong bao ket qua cap nhat.</returns>
        [GroupRoleAuthorize(1)]
        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser([FromBody] Account user)
        {
            var result = await _systemUserService.UpdateUserAsync(Guid.Parse(user.Id), user);
            if (result.Succeeded)
            {
                return Ok("Cap nhat nguoi dung thanh cong.");
            }
            return BadRequest(result.Errors);
        }

        /// <summary>
        /// Xoa nguoi dung theo ID.
        /// </summary>
        /// <param name="id">ID nguoi dung can xoa.</param>
        /// <returns>Thong bao ket qua xoa.</returns>
        [GroupRoleAuthorize(1)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var result = await _systemUserService.DeleteUserAsync(id);
            if (result.Succeeded)
            {
                return Ok("Xoa nguoi dung thanh cong.");
            }
            return BadRequest(result.Errors);
        }

        /// <summary>
        /// Tim kiem nguoi dung theo tu khoa.
        /// </summary>
        /// <param name="searchTerm">Tu khoa tim kiem.</param>
        /// <returns>Danh sach nguoi dung phu hop.</returns>
        [HttpGet("search")]
        public async Task<IActionResult> SearchUsers(string searchTerm)
        {
            var users = await _systemUserService.SearchUsersAsync(searchTerm);
            return Ok(users);
        }

        /// <summary>
        /// Reset mat khau cho nguoi dung.
        /// </summary>
        /// <param name="userId">ID nguoi dung can reset mat khau.</param>
        /// <returns>Thong bao ket qua reset mat khau.</returns>
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(string userId)
        {
            var result = await _systemUserService.ResetPasswordAsync(userId);
            if (result.Succeeded)
            {
                return Ok("Reset mat khau thanh cong.");
            }
            return BadRequest(result.Errors);
        }

        /// <summary>
        /// Import danh sach nguoi dung tu file.
        /// </summary>
        /// <param name="file">File CSV hoac Excel chua danh sach nguoi dung.</param>
        /// <returns>Thong bao ket qua import.</returns>
        [GroupRoleAuthorize(1)]
        [HttpPost("import")]
        public async Task<IActionResult> ImportUsers(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("File khong hop le.");
            }

            var extension = Path.GetExtension(file.FileName).ToLower();
            if (extension != ".csv" && extension != ".xlsx")
            {
                return BadRequest("Chi ho tro file CSV hoac Excel.");
            }

            try
            {
                Stream processedStream;

                if (extension == ".csv")
                {
                    processedStream = _systemUserService.ConvertCsvToExcel(file.OpenReadStream());
                }
                else
                {
                    processedStream = file.OpenReadStream();
                }

                var (added, updated, errors, errorLogs) = await _systemUserService.ImportUsersFromExcelAsync(processedStream);

                return Ok(new
                {
                    AddedUsers = added,
                    UpdatedUsers = updated,
                    ErrorCount = errors,
                    ErrorLogs = errorLogs
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Co loi xay ra: {ex.Message}");
            }
        }

        /// <summary>
        /// Export danh sach nguoi dung thanh file Excel.
        /// </summary>
        /// <returns>File Excel danh sach nguoi dung.</returns>
        [GroupRoleAuthorize(1)]
        [HttpGet("export")]
        public async Task<IActionResult> ExportUsers()
        {
            var fileContent = await _systemUserService.ExportUsersToExcelAsync();
            return File(fileContent, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Users.xlsx");
        }
    }
}
