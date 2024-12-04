using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Unilevel.Models
{
    public class SaleStaff : User
    {
        public string? ManagerId { get; set; }
        public ICollection<SaleDistributor> SaleDistributors { get; set; }
    }
}
