using Unilevel.Models;
using Unilevel.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Unilevel.Services
{
    public class ArticleService
    {
        private readonly AppDbContext _context;

        public ArticleService(AppDbContext context)
        {
            _context = context;
        }


        // Tim kiem
        public async Task<IEnumerable<ArticleDTO>> SearchArticlesAsync(string keyword)
        {
            return await _context.Articles
                .Where(a => a.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .Select(a => new ArticleDTO
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                    Author = a.Author,
                    CreateAt = a.CreateAt,
                    Status = a.Status.ToString()
                })
                .ToListAsync();
        }


        // Sua
        public async Task<bool> EditArticleAsync(int id, UpdateArticleDTO updatedArticle)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null) return false;

            article.Title = updatedArticle.Title;
            article.Description = updatedArticle.Description;
            article.ImageUrl = updatedArticle.ImageUrl;
            article.ArticleUrl = updatedArticle.ArticleUrl;

            await _context.SaveChangesAsync();
            return true;
        }


        // Xoa nhieu
        public async Task<bool> DeleteArticlesAsync(IEnumerable<int> ids)
        {
            var articlesToRemove = await _context.Articles.Where(a => ids.Contains(a.Id)).ToListAsync();
            if (!articlesToRemove.Any()) return false;

            _context.Articles.RemoveRange(articlesToRemove);
            await _context.SaveChangesAsync();
            return true;
        }


        // Xoa tung bai viet
        public async Task<bool> DeleteArticleAsync(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null) return false;

            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return true;
        }


        // Sua trang thai
        public async Task<bool> UpdateStatusAsync(int id, bool publish)
        {
            var article = await _context.Articles.FindAsync(id);
            if (article == null) return false;

            article.Status = publish ? Article.ArticleStatus.Published : Article.ArticleStatus.Disabled;
            await _context.SaveChangesAsync();
            return true;
        }


        // Tao
        public async Task<ArticleDTO> CreateArticleAsync(CreateArticleDTO newArticle)
        {
            var article = new Article
            {
                Title = newArticle.Title,
                Description = newArticle.Description,
                Author = newArticle.Author,
                ImageUrl = newArticle.ImageUrl,
                ArticleUrl = newArticle.ArticleUrl,
                CreateAt = DateTime.Now,
                Status = Article.ArticleStatus.Disabled
            };

            _context.Articles.Add(article);
            await _context.SaveChangesAsync();

            return new ArticleDTO
            {
                Id = article.Id,
                Title = article.Title,
                Description = article.Description,
                Author = article.Author,
                CreateAt = article.CreateAt,
                Status = article.Status.ToString()
            };
        }


        // Lay tat ca bai viet
        public async Task<IEnumerable<ArticleDTO>> GetAllArticlesAsync()
        {
            return await _context.Articles
                .Select(a => new ArticleDTO
                {
                    Id = a.Id,
                    Title = a.Title,
                    Description = a.Description,
                    Author = a.Author,
                    CreateAt = a.CreateAt,
                    Status = a.Status.ToString()
                })
                .ToListAsync();
        }
    }
}
