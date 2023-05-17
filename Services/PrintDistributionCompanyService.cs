using Data;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PrintDistributionCompanyService : IPrintDistributionCompanyService
    {
        private readonly IPrintDistributionCompanyRepository _repository;

        public PrintDistributionCompanyService(IPrintDistributionCompanyRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<PrintDistributionCompany> GetAll()
        {
            return _repository.GetAll();
        }

        public PrintDistributionCompany GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Add(PrintDistributionCompany entity)
        {
            _repository.Add(entity);
        }

        public void Update(PrintDistributionCompany entity)
        {
            _repository.Update(entity);
        }

        public void Delete(PrintDistributionCompany entity)
        {
            _repository.Delete(entity);
        }
    }
}
