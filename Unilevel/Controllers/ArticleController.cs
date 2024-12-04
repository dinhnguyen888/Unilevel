using Microsoft.AspNetCore.Mvc;
using Unilevel.DTOs;
using Unilevel.Services;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Unilevel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly ArticleService _articleService;

        public ArticleController(ArticleService articleService)
        {
            _articleService = articleService;
        }

        /// <summary>
        /// Tim kiem bai viet dua tren tu khoa
        /// </summary>
        /// <param name="keyword">Tu khoa de tim kiem cac bai viet tuong ung</param>
        /// <returns>Danh sach cac bai viet phu hop voi tu khoa</returns>
        [HttpGet("search")]
        public async Task<IActionResult> SearchArticles([FromQuery] string keyword)
        {
            var result = await _articleService.SearchArticlesAsync(keyword);
            return Ok(result);
        }

        /// <summary>
        /// Chinh sua mot bai viet hien tai theo ID
        /// </summary>
        /// <param name="id">Dinh danh duy nhat cua bai viet can chinh sua</param>
        /// <param name="updatedArticle">Thong tin bai viet da duoc cap nhat</param>
        /// <returns>Khong co noi dung neu thanh cong, hoac khong tim thay neu bai viet khong ton tai</returns>
        [CustomAuthorize("Can Update Article",1)]
        [HttpPut("{id}")]
        public async Task<IActionResult> EditArticle(int id, [FromBody] UpdateArticleDTO updatedArticle)
        {
            var result = await _articleService.EditArticleAsync(id, updatedArticle);
            if (!result) return NotFound("Khong tim thay bai viet.");
            return NoContent();
        }
    
        /// <summary>
        /// Xoa nhieu bai viet trong mot yeu cau
        /// </summary>
        /// <param name="ids">Tap hop cac ID bai viet can xoa</param>
        /// <returns>Khong co noi dung neu thanh cong, hoac khong tim thay neu mot so bai viet khong ton tai</returns>
        [CustomAuthorize("Can Delete Article", 1)]
        [HttpDelete("delete-multiple")]
        public async Task<IActionResult> DeleteArticles([FromBody] IEnumerable<int> ids)
        {
            var result = await _articleService.DeleteArticlesAsync(ids);
            if (!result) return NotFound("Khong tim thay cac bai viet.");
            return NoContent();
        }

        /// <summary>
        /// Xoa mot bai viet theo ID
        /// </summary>
        /// <param name="id">Dinh danh duy nhat cua bai viet can xoa</param>
        /// <returns>Khong co noi dung neu thanh cong, hoac khong tim thay neu bai viet khong ton tai</returns>
        [CustomAuthorize("Can Delete Article", 1)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var result = await _articleService.DeleteArticleAsync(id);
            if (!result) return NotFound("Khong tim thay bai viet.");
            return NoContent();
        }

        /// <summary>
        /// Cap nhat trang thai xuat ban cua bai viet
        /// </summary>
        /// <param name="id">Dinh danh duy nhat cua bai viet</param>
        /// <param name="publish">Gia tri Boolean chi dinh co xuat ban hay khong xuat ban bai viet</param>
        /// <returns>Khong co noi dung neu thanh cong, hoac khong tim thay neu bai viet khong ton tai</returns>
        [CustomAuthorize("Can Update Article", 1)]
        [HttpPatch("{id}/status")]
        public async Task<IActionResult> UpdateStatus(int id, [FromQuery] bool publish)
        {
            var result = await _articleService.UpdateStatusAsync(id, publish);
            if (!result) return NotFound("Khong tim thay bai viet.");
            return NoContent();
        }

        /// <summary>
        /// Tao moi mot bai viet
        /// </summary>
        /// <param name="newArticle">Doi tuong truyen tai chua thong tin bai viet moi</param>
        /// <returns>Bai viet da tao voi vi tri cua no</returns>
        [CustomAuthorize("Can Post Article", 1)]
        [HttpPost]
        public async Task<IActionResult> CreateArticle([FromBody] CreateArticleDTO newArticle)
        {
            var result = await _articleService.CreateArticleAsync(newArticle);
            return CreatedAtAction(nameof(GetAllArticles), result);
        }

        /// <summary>
        /// Lay tat ca cac bai viet
        /// </summary>
        /// <returns>Danh sach tat ca cac bai viet</returns>
        [GroupRoleAuthorize(1)]
        [HttpGet]
        public async Task<IActionResult> GetAllArticles()
        {
            var result = await _articleService.GetAllArticlesAsync();
            return Ok(result);
        }
    }
}