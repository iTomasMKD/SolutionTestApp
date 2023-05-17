using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PrintDistributionCompany
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        public ICollection<MagazineDistribution> MagazineDistributions { get; set; }
    }
}
