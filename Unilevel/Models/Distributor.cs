using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Unilevel.Models
{
    public class Distributor
    {
        public string UserId {  get; set; }
        public User User { get; set; }
        public string SaleManagementId { get; set; }
        public ICollection<SaleDistributor>? SaleDistributors { get; set; }

    }
}
