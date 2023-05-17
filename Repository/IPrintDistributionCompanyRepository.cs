using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IPrintDistributionCompanyRepository
    {
        IEnumerable<PrintDistributionCompany> GetAll();
        PrintDistributionCompany GetById(int id);
        void Add(PrintDistributionCompany entity);
        void Update(PrintDistributionCompany entity);
        void Delete(PrintDistributionCompany entity);
    }  
}
