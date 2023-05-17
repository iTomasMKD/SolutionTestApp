using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Subscription
    {
        [Key]      
        public int SubscriptionId { get; set; }
        public int CustomerId { get; set; }
        public int MagazineId { get; set; }
        public string DeliveryAddress { get; set; }

        public Customer Customer { get; set; }
        public Magazine Magazine { get; set; }
    }
}
