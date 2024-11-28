using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Unilevel.Models
{
    public class Distributor : User
    {

        public string SaleManagementId { get; set; }
        public ICollection<SaleDistributor> SaleDistributors { get; set; }

    }
}
