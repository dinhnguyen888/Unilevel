using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Unilevel.Models;

public class User : IdentityUser
{
    public string? PathPicture { get; set; } 
    public string? Address { get; set; }
    [ForeignKey("Area")]
    public string? AreaId { get; set; }
    public DateTime? JoinDate { get; set; }
    public bool? IsActive { get; set; }
    public string? Reporter { get; set; }
    public Area? Areas { get; set; }
    
}
