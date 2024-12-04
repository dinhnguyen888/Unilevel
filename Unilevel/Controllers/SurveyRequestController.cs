using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Unilevel.DTOs;
using Unilevel.Models;
using Unilevel.Services;

namespace Unilevel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SurveyRequestController : ControllerBase
    {
        private readonly SurveyRequestService _surveyRequestService;

        public SurveyRequestController(SurveyRequestService surveyRequestService)
        {
            _surveyRequestService = surveyRequestService;
        }

        /// <summary>
        /// Tao moi mot yeu cau khao sat
        /// </summary>
        /// <param name="dto">Doi tuong chua thong tin yeu cau khao sat moi</param>
        /// <returns>Thong tin yeu cau khao sat da tao</returns>
        /// <response code="200">Tao yeu cau khao sat thanh cong</response>
        /// <response code="400">Du lieu khong hop le hoac co loi xay ra</response>
        [CustomAuthorize("Can Post Survey Request", 1)]
        [HttpPost]
        public async Task<IActionResult> CreateSurveyRequest([FromBody] CreateSurveyRequestDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var result = await _surveyRequestService.CreateSurveyRequestAsync(dto);
                return Ok(result); // Tra ve thong tin yeu cau khao sat da tao
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        /// <summary>
        /// Lay danh sach nguoi nhan cho mot yeu cau khao sat
        /// </summary>
        /// <param name="surveyRequestId">Ma dinh danh cua yeu cau khao sat</param>
        /// <returns>Danh sach nguoi nhan</returns>
        /// <response code="200">Lay danh sach nguoi nhan thanh cong</response>
        /// <response code="404">Khong tim thay yeu cau khao sat</response>
        /// <response code="400">Co loi xay ra khi lay danh sach nguoi nhan</response>
        [HttpGet("{surveyRequestId}/receivers")]
        public async Task<IActionResult> GetSurveyReceivers(string surveyRequestId)
        {
            try
            {
                var receivers = await _surveyRequestService.GetSurveyReceiversAsync(surveyRequestId);
                return Ok(receivers); // Tra ve danh sach nguoi nhan
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        /// <summary>
        /// Lay danh sach yeu cau khao sat theo trang thai hoan thanh
        /// </summary>
        /// <param name="isCompleted">Trang thai hoan thanh cua yeu cau khao sat</param>
        /// <returns>Danh sach yeu cau khao sat theo trang thai</returns>
        /// <response code="200">Lay danh sach yeu cau khao sat thanh cong</response>
        [HttpGet("survey-requests/completion-status")]
        public async Task<IActionResult> GetSurveyRequestsByStatus(bool isCompleted)
        {
            var surveyRequests = await _surveyRequestService.GetSurveyRequestsByCompletionStatusAsync(isCompleted);
            return Ok(surveyRequests);
        }
    }
}