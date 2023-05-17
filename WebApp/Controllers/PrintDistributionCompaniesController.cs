using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System.Net;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrintDistributionCompaniesController : ControllerBase
    {
        private readonly IPrintDistributionCompanyRepository _repository;

        public PrintDistributionCompaniesController(IPrintDistributionCompanyRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<PrintDistributionCompany> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet]
        public PrintDistributionCompany Get(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] PrintDistributionCompany value)
        {
            _repository.Add(value);
        }

        [HttpPut]
        public void Put(int id, [FromBody] PrintDistributionCompany value)
        {
            _repository.Update(value);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var entity = _repository.GetById(id);
            if (entity != null)
            {
                _repository.Delete(entity);
            }
        }
    }
}
