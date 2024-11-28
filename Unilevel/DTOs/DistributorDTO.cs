namespace Unilevel.DTOs
{
    public class DistributorDTO
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string SaleManagement { get; set; }
        public ICollection<string> Sales { get; set; }
    }
}
