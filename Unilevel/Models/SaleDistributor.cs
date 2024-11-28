namespace Unilevel.Models
{
    public class SaleDistributor
    {
        public string SaleStaffId { get; set; }
        public SaleStaff SaleStaff { get; set; }
        public string DistributorId { get; set; }
        public Distributor Distributor { get; set; }

    }
}
