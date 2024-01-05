using System.ComponentModel.DataAnnotations;

namespace TruckManagement.Models
{
    public class Status
    {
        public int ID { get; set; }

        [Display(Name = "Status")]
        public string StatusName { get; set; }
        public ICollection<Delivery>? Deliveries { get; set; }
    }
}
