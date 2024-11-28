using Microsoft.AspNetCore.Mvc;
using Unilevel.DTOs;
using Unilevel.Services;

namespace Unilevel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitCalendarController : ControllerBase
    {
        private readonly VisitCalendarService _visitCalendarService;

        public VisitCalendarController(VisitCalendarService visitCalendarService)
        {
            _visitCalendarService = visitCalendarService;
        }

        // Lấy tất cả lịch viếng thăm
        [CustomAuthorize("ReadVisitCalendarInArea", 1)]
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
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Tạo lịch viếng thăm
        [CustomAuthorize("CreateVisitCalendar", 1)]
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

                return Ok("Lịch viếng thăm đã được tạo thành công.");
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Tìm kiếm lịch viếng thăm
     
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
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Lọc lịch viếng thăm

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
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("visit-history")]
        public IActionResult GetVisitHistory()
        {
            try
            {
                var visitHistory = _visitCalendarService.GetVisitHistory();
                return Ok(visitHistory);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        // Lấy các chuyến thăm sắp tới
  
        [HttpGet("upcoming-visits")]
        public IActionResult GetUpcomingVisits()
        {
            try
            {
                var upcomingVisits = _visitCalendarService.GetUpcomingVisits();
                return Ok(upcomingVisits);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
