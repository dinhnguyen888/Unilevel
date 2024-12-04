namespace Unilevel.Models
{
    public class JobDetail
    {
        public int Id { get; set; } 
        public string? LinkFileForCreatorReporter { get; set; }
        public string? LinkFileForWorkingPerson { get; set; }
        public int? TaskStar {  get; set; }
        public ICollection<CommentForJob>? CommentForJob {  get; set; } 
    }
}
