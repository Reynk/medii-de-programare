using System.ComponentModel.DataAnnotations;

namespace TruckManagement.Models
{
    public class User
    {
        public int ID { get; set; }

        [Display(Name = "Full Name")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s-]*$", ErrorMessage = "Prenumele trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau AnaMaria")]
        public string? UserName { get; set; }
        public string Email { get; set; }
    }
}