using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Unilevel.Models
{
    public class Role : IdentityRole
    {
        [Required]
        public int GroupRoleId { get; set; }
        public GroupRole GroupRole { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}
