using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Unilevel.DTOs;
using Unilevel.Services;

namespace Unilevel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobForVisitationController : ControllerBase
    {
        private readonly JobForVisitationService _jobService;

        public JobForVisitationController(JobForVisitationService jobService)
        {
            _jobService = jobService;
        }

        // GET: api/JobForVisitation/VisitCalendar/{visitCalendarId}
        [HttpGet("get-all-job-in-calendar/{visitCalendarId}")]
        public IActionResult GetJobsByVisitCalendarId(int visitCalendarId)
        {
            var jobs = _jobService.GetJobsByVisitCalendarId(visitCalendarId);
            return Ok(jobs);
        }

        // POST: api/JobForVisitation
        [HttpPost("create-job")]
        public IActionResult CreateJob(JobForVisitationDTO jobDto)
        {

            try
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value.ToString();

                var result = _jobService.CreateJob(jobDto, userId);
                return Ok(new { Message = result });
            }
            catch (Exception ex)
            {
                return StatusCode(400, new { Message = "An error occurred while creating the job.", Error = ex.Message });
            }
        }

        // GET: api/JobForVisitation/WorkingPerson/{workingPerson}
        [HttpGet("get-my-job/{workingPerson}")]
        public IActionResult GetJobsByWorkingPerson(string workingPerson)
        {
            var jobs = _jobService.GetJobsByWorkingPerson(workingPerson);
            return Ok(jobs);
        }

        [HttpPost("upload-image")]
        public async Task<IActionResult> UploadImage(int jobId,IFormFile file, string uploadPerson)
        {
            try
            {
                var result = await _jobService.UploadImageAsync(jobId, file, uploadPerson);
                return Ok(new { Message = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Lỗi hệ thống: {ex.Message}");
            }
        }

        [HttpPost("change-job-status")]
        public async Task<IActionResult> ChangeJobStatus(int jobId, string jobStatus)
        {
            try
            {
                var result = await _jobService.changeJobStatus(jobId, jobStatus);

                if (result.Contains("không hợp lệ") || result.Contains("không tồn tại"))
                {
                    return BadRequest(result); 
                }

                return Ok(result);  
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Đã xảy ra lỗi: " + ex.Message);
            }
        }

    }
}
