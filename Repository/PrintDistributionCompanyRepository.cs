using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PrintDistributionCompanyRepository : IPrintDistributionCompanyRepository
    {
        private readonly PublishingCompanyDbContext _context;

        public PrintDistributionCompanyRepository(PublishingCompanyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<PrintDistributionCompany> GetAll()
        {
            return _context.Set<PrintDistributionCompany>().ToList();
        }

        public PrintDistributionCompany GetById(int id)
        {
            return _context.Set<PrintDistributionCompany>().Find(id);
        }

        public void Add(PrintDistributionCompany entity)
        {
            _context.Set<PrintDistributionCompany>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(PrintDistributionCompany entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(PrintDistributionCompany entity)
        {
            _context.Set<PrintDistributionCompany>().Remove(entity);
            _context.SaveChanges();
        }
    }
}

