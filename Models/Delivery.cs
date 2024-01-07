using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace TruckManagement.Models
{
    public class Delivery
    {
        public int ID { get; set; }
        //public int DriverID { get; set; }
        //public int statusID { get; set; }

        [Display(Name = "Start Location")]
        [RegularExpression(@"^[A-Z]+[a-z\s]*$")]
        [StringLength(50, MinimumLength = 3)]
        public string? StartLocation { get; set; }

        [Display(Name = "End Location")]
        [RegularExpression(@"^[A-Z]+[a-z\s]*$")]
        [StringLength(50, MinimumLength = 3)]
        public string? EndLocation { get; set; }

        [Display(Name = "Reference Phone Number")]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Telefonul trebuie sa fie de forma '0722-123-123' sau'0722.123.123' sau '0722 123 123'")]
        public int PhoneNumber { get; set; }

        public int? UserID { get; set; }
        public User? User { get; set; }

        public int? StatusID { get; set; }

        [Display(Name = "Current Status")]
        public Status? Status { get; set; }
    }
}
