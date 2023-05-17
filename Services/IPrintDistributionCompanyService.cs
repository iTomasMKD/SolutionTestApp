using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    //[ServiceContract]
    public interface IPrintDistributionCompanyService
    {
        //[OperationContract]
        IEnumerable<PrintDistributionCompany> GetAll();

        //[OperationContract]
        PrintDistributionCompany GetById(int id);

        //[OperationContract]
        void Add(PrintDistributionCompany entity);

        //[OperationContract]
        void Update(PrintDistributionCompany entity);

        //[OperationContract]
        void Delete(PrintDistributionCompany entity);
    }
}
