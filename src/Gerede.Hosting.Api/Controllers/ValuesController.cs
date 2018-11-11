using Gerede.Domain.Core.UnitOfWork;
using Gerede.Domain.Data.Models.Entities.IdentityServer;
using Gerede.Hosting.Core;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Gerede.Hosting.Api.Controllers
{
    public class ValuesController : BaseApiController
    {
        readonly IUnitOfWork _unitOfWork;

        public ValuesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var qu =_unitOfWork.GetRepository<ClientEntity>().GetAllQuery();
            var qu2 = _unitOfWork.GetRepository<ApiResourceEntity>().GetAllQuery();
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
