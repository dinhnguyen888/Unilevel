namespace Unilevel.DTOs
{
    public class ArticleDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime CreateAt { get; set; }
        public string Status { get; set; }
    }

    public class CreateArticleDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string ImageUrl { get; set; }
        public string ArticleUrl { get; set; }
    }

    public class UpdateArticleDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ArticleUrl { get; set; }
    }
}
