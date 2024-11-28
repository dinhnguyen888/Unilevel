using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Unilevel.Models
{
    public class CommentForJob
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UserComment { get; set; }

        public string Comment { get; set; }
        public int JobId { get; set; }
        public JobDetail JobDetail { get; set; }
    }
}
