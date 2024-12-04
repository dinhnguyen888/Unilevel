namespace Unilevel.DTOs
{
    public class SaleStaffDTO
    {
        public string? Id { get; set; } 
        public string FullName { get; set; }
        public string Email { get; set; }
        public string RoleId { get; set; }
        public string? ManagerId { get; set; }
        public ICollection<string>? InferiorId { get; set; }
        public string? AreaId { get; set; }
        public bool? IsActive { get; set; }
    }
}
