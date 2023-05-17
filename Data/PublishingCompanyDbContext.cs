using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class PublishingCompanyDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Magazine> Magazines { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<PrintDistributionCompany> PrintDistributionCompanies { get; set; }
        public DbSet<MagazineDistribution> MagazineDistributions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PublishingCompany");
        }
    }
}
