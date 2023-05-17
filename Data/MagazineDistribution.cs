using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MagazineDistribution
    {
        [Key]
        public int MagazineId { get; set; }
        public string Country { get; set; }

        public int CompanyId { get; set; }

        //Navigation Properties
        public Magazine Magazine { get; set; }
        public PrintDistributionCompany PrintDistributionCompany { get; set; }
    }
}
