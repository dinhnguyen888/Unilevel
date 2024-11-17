using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public string? PathPicture { get; set; } 
    public string? Address { get; set; }
    public string? Area { get; set; }
    public DateTime? JoinDate { get; set; }
    public bool? IsActive { get; set; }
    public string? Reporter { get; set; }

}
