using Microsoft.AspNetCore.Identity;

namespace Unilevel.Models
{
    public class User : IdentityUser
    {
        public string? Initails { get; set; }
    }
}



