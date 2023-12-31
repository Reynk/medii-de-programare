﻿using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

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

        public int? StatusID { get; set; }

        [Display(Name = "Current Status")]
        public Status? Status { get; set; }
    }
}
