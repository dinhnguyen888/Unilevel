using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Unilevel.Models
{
    public class SaleStaff : User
    {
        [Key]
        [Required]
        public string Id { get; set; }

        public string? SuperiorId { get; set; }

        [ForeignKey(nameof(SuperiorId))]
        [JsonIgnore] // Để tránh vòng lặp khi trả về JSON
        public SaleStaff? Superior { get; set; }

        public ICollection<SaleStaff>? Inferiors { get; set; }

        public ICollection<SaleDistributor> SaleDistributors { get; set; }
    }
}
