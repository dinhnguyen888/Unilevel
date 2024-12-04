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

        /// <summary>
        /// Lay danh sach cong viec theo lich tham quan
        /// </summary>
        /// <param name="visitCalendarId">Ma lich tham quan</param>
        /// <returns>Danh sach cong viec</returns>
        [CustomAuthorize("Can Get Task", 1)]
        [HttpGet("get-all-job-in-calendar/{visitCalendarId}")]
        public IActionResult GetJobsByVisitCalendarId(int visitCalendarId)
        {
            var jobs = _jobService.GetJobsByVisitCalendarId(visitCalendarId);
            return Ok(jobs);
        }

        /// <summary>
        /// Tao moi mot cong viec
        /// </summary>
        /// <param name="jobDto">Thong tin cong viec</param>
        /// <returns>Ket qua tao cong viec</returns>
        [CustomAuthorize("Can Post Task", 1)]
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
                return StatusCode(400, new { Message = "Co loi xay ra khi tao cong viec.", Error = ex.Message });
            }
        }

        /// <summary>
        /// Lay danh sach cong viec theo nguoi thuc hien
        /// </summary>
        /// <param name="workingPerson">Ma nguoi thuc hien</param>
        /// <returns>Danh sach cong viec</returns>
        [HttpGet("get-my-job/{workingPerson}")]
        public IActionResult GetJobsByWorkingPerson(string workingPerson)
        {
            var jobs = _jobService.GetJobsByWorkingPerson(workingPerson);
            return Ok(jobs);
        }

        /// <summary>
        /// Tai len hinh anh cho cong viec
        /// </summary>
        /// <param name="jobId">Ma cong viec</param>
        /// <param name="file">Tap tin hinh anh</param>
        /// <param name="uploadPerson">Nguoi tai len</param>
        /// <returns>Ket qua tai len</returns> 
        [HttpPost("upload-image")]
        public async Task<IActionResult> UploadImage(int jobId, IFormFile file, string uploadPerson)
        {
            try
            {
                var result = await _jobService.UploadImageAsync(jobId, file, uploadPerson); // uploadPerson la CreatorReporter hoac WorkingPerson
                return Ok(new { Message = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Loi he thong: {ex.Message}");
            }
        }

        /// <summary>
        /// Thay doi trang thai cong viec
        /// </summary>
        /// <param name="jobId">Ma cong viec</param>
        /// <param name="jobStatus">Trang thai moi</param>
        /// <returns>Ket qua thay doi trang thai</returns>
        [CustomAuthorize("Can Change Task Status", 1)]
        [HttpPost("change-job-status")]
        public async Task<IActionResult> ChangeJobStatus(int jobId, string jobStatus)
        {
            try
            {
                var result = await _jobService.changeJobStatus(jobId, jobStatus);

                if (result.Contains("khong hop le") || result.Contains("khong ton tai"))
                {
                    return BadRequest(result);
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Da xay ra loi: " + ex.Message);
            }
        }

        /// <summary>
        /// Gui binh luan cho cong viec
        /// </summary>
        /// <param name="commentForJobDTO">Thong tin binh luan</param>
        /// <returns>Ket qua gui binh luan</returns>
        [HttpPost("send-comment")]
        public async Task<IActionResult> SendComment([FromBody] CommentForJobDTO commentForJobDTO)
        {
            if (commentForJobDTO == null)
            {
                return BadRequest("Binh luan khong hop le");
            }

            try
            {
                string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                if (string.IsNullOrEmpty(userId))
                {
                    return Unauthorized("Nguoi dung chua dang nhap");
                }

                await _jobService.SendComment(userId, commentForJobDTO);

                return Ok(new { message = "Binh luan da duoc gui thanh cong" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        /// <summary>
        /// Danh gia cong viec
        /// </summary>
        /// <param name="rateTaskDTO">Thong tin danh gia</param>
        /// <returns>Ket qua danh gia</returns>
        [HttpPost("rate-task")]
        public async Task<IActionResult> RateTaskAsync([FromBody] RateTaskDTO rateTaskDTO)
        {
            try
            {
                var result = await _jobService.RateTaskAsync(rateTaskDTO.JobId, rateTaskDTO.TaskStar, 1, 5);
                return Ok(new { Message = result });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }
    }
}