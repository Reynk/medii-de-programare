namespace TruckManagement.Models
{
    public class Delivery
    {
        public int ID { get; set; }
        //public int DriverID { get; set; }
        //public int statusID { get; set; }
        public string? StartLocation { get; set; }
        public string? EndLocation { get; set; }
        public int PhoneNumber { get; set; }
    }
}
