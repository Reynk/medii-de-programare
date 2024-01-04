namespace TruckManagement.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public User Driver { get; set; }
        public Status DeliveryStatus { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public int PhoneNumber { get; set; }
    }
}