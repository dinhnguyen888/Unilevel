namespace Unilevel.DTOs
{
    public class Account
    {
        public string Id { get; set; }
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Role { get; set; }
        public string? Area { get; set; }
        public DateTime? JoinDate { get; set; }
        public bool? IsActive { get; set; }
        public string? Reporter { get; set; }
    }
}
