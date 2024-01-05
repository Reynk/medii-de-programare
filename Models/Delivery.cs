using System.ComponentModel.DataAnnotations;

namespace TruckManagement.Models
{
    public class Delivery
    {
        public int ID { get; set; }
        //public int DriverID { get; set; }
        //public int statusID { get; set; }

        [Display(Name = "Start Location")]
        public string? StartLocation { get; set; }

        [Display(Name = "End Location")]
        public string? EndLocation { get; set; }

        [Display(Name = "Reference Phone Number")]
        public int PhoneNumber { get; set; }
    }
}
