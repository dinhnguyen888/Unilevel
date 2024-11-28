using System.ComponentModel.DataAnnotations;
namespace Unilevel.Models
{
    public class GroupRole
    {
        [Key]
        [Required]
        public int GroupRoleId { get; set; }
        [Required]
        public string GroupRoleName { get; set; }
    }
}
