using System.ComponentModel.DataAnnotations;

namespace TruckManagement.Models
{
    public class User
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }
    }
}