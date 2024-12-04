using Microsoft.AspNetCore.Mvc;
using Unilevel.DTOs;
using Unilevel.Services;

namespace Unilevel.Controllers
{
    /// <summary>
    /// API quan ly lich vieng tham
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class VisitCalendarController : ControllerBase
    {
        private readonly VisitCalendarService _visitCalendarService;

        public VisitCalendarController(VisitCalendarService visitCalendarService)
        {
            _visitCalendarService = visitCalendarService;
        }

        /// <summary>
        /// Lay tat ca lich vieng tham
        /// </summary>
        /// <response code="200">Lay thanh cong</response>
        /// <response code="401">Khong co quyen truy cap</response>
        /// <response code="500">Loi he thong</response>
        [HttpGet("visit-calendar")]
        public IActionResult GetVisitCalendar()
        {
            try
            {
                var (permissions, userId) = _visitCalendarService.GetUserPermissions();

                var visitCalendars = permissions.Contains("ReadVisitCalendarInArea")
                    ? _visitCalendarService.GetVisitCalendarByAreaId(userId)
                    : _visitCalendarService.GetAllVisitCalendar();

                return Ok(visitCalendars);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized("Khong co quyen truy cap: " + ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Loi he thong: " + ex.Message);
            }
        }

        /// <summary>
        /// Tao lich vieng tham moi
        /// </summary>
        /// <response code="200">Tao thanh cong</response>
        /// <response code="400">Du lieu khong hop le</response>
        /// <response code="401">Khong co quyen truy cap</response>
        /// <response code="500">Loi he thong</response>
        [HttpPost("visit-calendar")]
        public IActionResult CreateVisitCalendar([FromBody] ScheduleVisitCalendarDTO request)
        {
            try
            {
                _visitCalendarService.ScheduleVisitCalendar(
                    request.ImplementationDates,
                    request.ImplementationTime,
                    request.VisitPurpose,
                    request.VisitorIds,
                    request.DistributorId
                );

                return Ok("Lich vieng tham da duoc tao thanh cong.");
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized("Khong co quyen truy cap: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest("Du lieu khong hop le: " + ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Loi he thong: " + ex.Message);
            }
        }

        /// <summary>
        /// Tim kiem lich vieng tham
        /// </summary>
        /// <param name="keyword">Tu khoa tim kiem</param>
        /// <response code="200">Tim kiem thanh cong</response>
        /// <response code="401">Khong co quyen truy cap</response>
        /// <response code="500">Loi he thong</response>
        [HttpGet("search")]
        public IActionResult SearchVisitCalendars([FromQuery] string keyword)
        {
            try
            {
                var visitCalendars = _visitCalendarService.SearchVisitCalendars(keyword);
                return Ok(visitCalendars);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized("Khong co quyen truy cap: " + ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Loi he thong: " + ex.Message);
            }
        }

        /// <summary>
        /// Loc lich vieng tham
        /// </summary>
        /// <param name="startDate">Ngay bat dau</param>
        /// <param name="endDate">Ngay ket thuc</param>
        /// <param name="status">Trang thai</param>
        /// <param name="distributorId">Ma nha phan phoi</param>
        /// <response code="200">Loc thanh cong</response>
        /// <response code="401">Khong co quyen truy cap</response>
        /// <response code="500">Loi he thong</response>
        [HttpGet("filter")]
        public IActionResult FilterVisitCalendars([FromQuery] DateTime? startDate, [FromQuery] DateTime? endDate, [FromQuery] string status, [FromQuery] string distributorId)
        {
            try
            {
                var visitCalendars = _visitCalendarService.FilterVisitCalendars(startDate, endDate, status, distributorId);
                return Ok(visitCalendars);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized("Khong co quyen truy cap: " + ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Loi he thong: " + ex.Message);
            }
        }

        /// <summary>
        /// Lay lich su cac lan vieng tham
        /// </summary>
        /// <response code="200">Lay thanh cong</response>
        /// <response code="500">Loi he thong</response>
        [HttpGet("visit-history")]
        public IActionResult GetVisitHistory()
        {
            try
            {
                var visitHistory = _visitCalendarService.GetVisitHistory();
                return Ok(visitHistory);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Loi he thong: " + ex.Message);
            }
        }

        /// <summary>
        /// Lay cac lich vieng tham sap toi
        /// </summary>
        /// <response code="200">Lay thanh cong</response>
        /// <response code="500">Loi he thong</response>
        [HttpGet("upcoming-visits")]
        public IActionResult GetUpcomingVisits()
        {
            try
            {
                var upcomingVisits = _visitCalendarService.GetUpcomingVisits();
                return Ok(upcomingVisits);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Loi he thong: " + ex.Message);
            }
        }

        /// <summary>
        /// Tu choi loi moi vieng tham
        /// </summary>
        /// <param name="visitCalendarId">Ma lich vieng tham</param>
        /// <param name="visitorId">Ma nguoi vieng tham</param>
        /// <response code="200">Tu choi thanh cong</response>
        /// <response code="400">Loi khi tu choi</response>
        [HttpPost("refuse-visit-invitation")]
        public IActionResult RefuseVisitInvitation(int visitCalendarId, string visitorId)
        {
            try
            {
                _visitCalendarService.RefuseVisitInvitation(visitCalendarId, visitorId);
                return Ok(new { message = "Da tu choi loi moi thanh cong." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        /// <summary>
        /// Huy lich vieng tham
        /// </summary>
        /// <param name="visitCalendarId">Ma lich vieng tham</param>
        /// <response code="200">Huy thanh cong</response>
        /// <response code="400">Loi khi huy</response>
        [HttpPut("{visitCalendarId}/cancel")]
        public IActionResult CancelVisitCalendar(int visitCalendarId)
        {
            try
            {
                _visitCalendarService.CancelVisitCalendar(visitCalendarId);
                return Ok(new { message = "Da huy lich vieng tham." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        /// <summary>
        /// Xoa lich vieng tham
        /// </summary>
        /// <param name="visitCalendarId">Ma lich vieng tham</param>
        /// <response code="200">Xoa thanh cong</response>
        /// <response code="400">Loi khi xoa</response>
        [HttpDelete("{visitCalendarId}")]
        public IActionResult DeleteVisitCalendar(int visitCalendarId)
        {
            try
            {
                _visitCalendarService.DeleteVisitCalendar(visitCalendarId);
                return Ok(new { message = "Da xoa hoan toan lich vieng tham." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
