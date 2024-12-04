using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unilevel.DTOs;
using Unilevel.Services;

namespace Unilevel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly SurveyService _surveyService;

        public SurveyController(SurveyService surveyService)
        {
            _surveyService = surveyService;
        }

        /// <summary>
        /// Lay danh sach tat ca cac khao sat
        /// </summary>
        /// <returns>Danh sach cac khao sat</returns>
        /// <response code="200">Tra ve danh sach khao sat thanh cong</response>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SurveyListDTO>>> GetAllSurveys()
        {
            var surveys = await _surveyService.GetAllSurveysAsync();
            return Ok(surveys);
        }

        /// <summary>
        /// Tim kiem khao sat theo tu khoa
        /// </summary>
        /// <param name="keyword">Tu khoa tim kiem</param>
        /// <returns>Danh sach khao sat theo tu khoa</returns>
        /// <response code="200">Tra ve danh sach khao sat tim kiem thanh cong</response>
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<SurveyListDTO>>> SearchSurveys([FromQuery] string keyword)
        {
            var surveys = await _surveyService.SearchSurveysAsync(keyword);
            return Ok(surveys);
        }

        /// <summary>
        /// Cap nhat trang thai khao sat
        /// </summary>
        /// <param name="dto">Doi tuong chua thong tin cap nhat trang thai</param>
        /// <returns>Ket qua cap nhat trang thai</returns>
        /// <response code="204">Cap nhat trang thai thanh cong</response>
        /// <response code="404">Khong tim thay khao sat</response>
        [GroupRoleAuthorize(1)]
        [HttpPut("update-status")]
        public async Task<ActionResult> UpdateSurveyStatus([FromBody] UpdateSurveyStatusDTO dto)
        {
            var result = await _surveyService.UpdateSurveyStatusAsync(dto);
            if (!result) return NotFound("Khong tim thay khao sat.");
            return NoContent();
        }

        /// <summary>
        /// Xoa khao sat theo ma dinh danh
        /// </summary>
        /// <param name="id">Ma dinh danh cua khao sat</param>
        /// <returns>Ket qua xoa khao sat</returns>
        /// <response code="204">Xoa khao sat thanh cong</response>
        /// <response code="404">Khong tim thay khao sat</response>
        [GroupRoleAuthorize(1)]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteSurvey(int id)
        {
            var result = await _surveyService.DeleteSurveyAsync(id);
            if (!result) return NotFound("Khong tim thay khao sat.");
            return NoContent();
        }

        /// <summary>
        /// Tao moi mot khao sat
        /// </summary>
        /// <param name="dto">Doi tuong chua thong tin khao sat moi</param>
        /// <returns>Khao sat vua duoc tao</returns>
        /// <response code="201">Tao khao sat thanh cong</response>
        [CustomAuthorize("Can Post Survey", 1)]
        [HttpPost]
        public async Task<ActionResult<SurveyListDTO>> CreateSurvey([FromBody] CreateSurveyDTO dto)
        {
            var survey = await _surveyService.CreateSurveyAsync(dto);
            var createdSurvey = new SurveyListDTO
            {
                No = survey.Id, 
                SurveyName = survey.SurveyName,
                CreatorId = survey.CreatorId,
                QuestionCount = 0,
                Status = survey.Status
            };
            return CreatedAtAction(nameof(GetAllSurveys), new { id = survey.Id }, createdSurvey);
        }

        /// <summary>
        /// Cap nhat ten khao sat
        /// </summary>
        /// <param name="dto">Doi tuong chua thong tin cap nhat ten khao sat</param>
        /// <returns>Ket qua cap nhat ten khao sat</returns>
        /// <response code="204">Cap nhat ten thanh cong</response>
        /// <response code="404">Khong tim thay khao sat</response>
        [CustomAuthorize("Can Update Survey", 1)]
        [HttpPut("update-title")]
        public async Task<ActionResult> UpdateSurveyTitle([FromBody] UpdateSurveyTitleDTO dto)
        {
            var result = await _surveyService.UpdateSurveyTitleAsync(dto);
            if (!result) return NotFound("Khong tim thay khao sat.");
            return NoContent();
        }

        /// <summary>
        /// Cap nhat cac cau hoi trong khao sat
        /// </summary>
        /// <param name="dto">Doi tuong chua thong tin cap nhat cau hoi</param>
        /// <returns>Ket qua cap nhat cau hoi khao sat</returns>
        /// <response code="200">Cap nhat cau hoi thanh cong</response>
        /// <response code="400">Du lieu khong hop le</response>
        /// <response code="404">Khong tim thay khao sat hoac cap nhat that bai</response>
        [CustomAuthorize("can Update Survey", 1)]
        [HttpPut("update-questions")]
        public async Task<IActionResult> UpdateSurveyQuestions([FromBody] UpdateSurveyQuestionsDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _surveyService.UpdateSurveyQuestionsAsync(dto);
            if (result == null)
            {
                return NotFound(new { Message = "Khong tim thay khao sat hoac cap nhat that bai." });
            }
            return Ok(new { Status = "Success", Message = "Cap nhat khao sat thanh cong.", Data = result });
        }
    }
}