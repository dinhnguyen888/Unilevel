using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Unilevel.Models;
using Unilevel.Services;

namespace Unilevel.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class SurveyResponseController : ControllerBase
    {
        private readonly SurveyResponseService _service;

        public SurveyResponseController(SurveyResponseService service)
        {
            _service = service;
        }

        /// <summary>
        /// Cap nhat cau tra loi khao sat.
        /// </summary>
        /// <param name="response">Thong tin cau tra loi khao sat can cap nhat.</param>
        /// <returns>Thong bao ket qua cap nhat.</returns>
        [HttpPost("update")]
        public async Task<IActionResult> UpdateSurveyResponse([FromBody] SurveyResponse response)
        {
            var result = await _service.UpdateSurveyResponseAsync(response);
            if (!result)
                return BadRequest("Cap nhat that bai. Vui long kiem tra thong tin.");

            return Ok("Cap nhat thanh cong.");
        }

        /// <summary>
        /// Lay danh sach cau tra loi theo ID nguoi dung.
        /// </summary>
        /// <param name="userId">ID cua nguoi dung.</param>
        /// <returns>Danh sach cac cau tra loi.</returns>
        [HttpGet("{userId}/responses")]
        public async Task<IActionResult> GetSurveyResponsesByUserId(string userId)
        {
            var responses = await _service.GetSurveyResponsesByUserIdAsync(userId);
            if (responses == null || !responses.Any())
                return NotFound("Khong tim thay cau tra loi.");

            return Ok(responses);
        }
    }
}
