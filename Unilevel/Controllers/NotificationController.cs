using Microsoft.AspNetCore.Mvc;
using Unilevel.Services;
using Unilevel.Models;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Unilevel.DTOs;

namespace Unilevel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NotificationController : ControllerBase
    {
        private readonly NotificationService _notificationService;

        public NotificationController(NotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        /// <summary>
        /// Gui thong bao toi danh sach nguoi dung
        /// </summary>
        /// <param name="request">Thong tin thong bao can gui</param>
        /// <returns>Thong bao da duoc tao</returns>
        /// <response code="200">Gui thong bao thanh cong</response>
        /// <response code="400">Loi khi tao hoac gui thong bao</response>
        [CustomAuthorize("Can Send Notification", 1)]
        [HttpPost("sendToUsers")]
        public async Task<ActionResult<Notification>> SendNotificationToUsersAsync([FromBody] NotificationRequest request)
        {
            try
            {
                var notification = await _notificationService.CreateNotificationAsync(
                    request.Title,
                    request.Description,
                    request.UserIds,
                    User
                );
                return Ok(notification);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Khong the tao hoac gui thong bao." });
            }
        }

        /// <summary>
        /// Gui thong bao toi tat ca nguoi dung trong cung khu vuc
        /// </summary>
        /// <param name="request">Thong tin thong bao can gui</param>
        /// <returns>Thong bao da duoc tao</returns>
        /// <response code="200">Gui thong bao thanh cong</response>
        /// <response code="400">Loi khi tao hoac gui thong bao</response>
        [CustomAuthorize("Can Send Notification", 1)]
        [HttpPost("sendToArea")]
        public async Task<ActionResult<Notification>> SendNotificationToAreaAsync([FromBody] NotificationRequest request)
        {
            try
            {
                var notification = await _notificationService.SendNotificationToAreaAsync(
                    request.Title,
                    request.Description,
                    User
                );
                return Ok(notification);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Khong the gui thong bao den khu vuc." });
            }
        }

        /// <summary>
        /// Lay danh sach thong bao cua nguoi dung
        /// </summary>
        /// <returns>Danh sach cac thong bao</returns>
        /// <response code="200">Lay thong bao thanh cong</response>
        /// <response code="400">Loi khi lay thong bao</response>
        [HttpGet("getNotifications")]
        public async Task<ActionResult> GetNotificationsForUserAsync()
        {
            try
            {
                var notifications = await _notificationService.GetNotificationsForUserAsync(User);
                return Ok(notifications);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Khong the lay danh sach thong bao." });
            }
        }
    }
}