namespace Unilevel.DTOs
{
    public class SaleStaffDTO
    {
        public string? Id { get; set; } // Để phục vụ chỉnh sửa
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string? SuperiorId { get; set; }
        public string? AreaId { get; set; }
        public bool IsActive { get; set; }
    }
}
