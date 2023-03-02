using Microsoft.AspNetCore.Identity;

namespace ASPPractice.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
