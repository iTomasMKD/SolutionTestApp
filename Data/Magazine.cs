using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Magazine
    {
        [Key]
        public int MagazineId { get; set; }
        public string MagazineName { get; set; }

        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<MagazineDistribution> MagazineDistributions { get; set; }
    }
}
