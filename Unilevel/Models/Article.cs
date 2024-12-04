namespace Unilevel.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime CreateAt { get; set; }
        public ArticleStatus Status { get; set; }
        public string ImageUrl { get; set; }
        public string ArticleUrl { get; set; }

        public enum ArticleStatus
        {
            Published,
            Disabled
        }
    }
}
