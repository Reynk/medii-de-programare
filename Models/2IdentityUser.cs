using Microsoft.AspNetCore.Identity;

namespace TruckManagement.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsAdmin { get; set; }
        // You can add more custom properties here if needed
    }
}