using System.ComponentModel.DataAnnotations;

namespace Unilevel.Models
{
    public class Area
    {
        [Key] 
        [Required] 
        public string AreaId { get; set; }

        [Required] 
        [MaxLength(100)]
        public string AreaName { get; set; }
    }
}
