using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Models
{
    public class Order
    {
        public string OrderId { get; set; }
        public string Status { get; set; }
        public DateTime OrderPlacedTime { get; set; }
        public string Adress { get; set; }
        public string CustomerCNIC { get; set; }

        public string DeliveryDate { get; set; }

        public string ShipingMethod { get; set; }

        public string items { get; set; }

      
    }
}
