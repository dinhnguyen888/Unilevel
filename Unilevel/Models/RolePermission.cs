namespace Unilevel.Models
{
    public class RolePermission
    {
        public string RoleId { get; set; }
        public Role Role { get; set; }  // Mối quan hệ với bảng User

        public int PermissionId { get; set; }
        public Permission Permission { get; set; }  // Mối quan hệ với bảng Permission
    }
}
