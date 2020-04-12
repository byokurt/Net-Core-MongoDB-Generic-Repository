using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using MongoDBExample.Business.Abstractions;
using MongoDBExample.Entities.ClientEntities.Response;
using MongoDBExample.Entities.ClientEntities.Request;

namespace MongoDBExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        private readonly IServiceProvider _collection;

        public ExampleController(IServiceProvider collection)
        {
            _collection = collection;
        }

        [HttpPost]
        [Route("Add")]
        public bool Add(AddPersonRequest request)
        {
            using (var scope = _collection.CreateScope())
            {
                return _collection.GetService<IPersonService>().Add(request);
            }
        }

        [HttpGet]
        [Route("Get")]
        public GetPersonResponse Get(Guid q)
        {
            using (var scope = _collection.CreateScope())
            {
                return _collection.GetService<IPersonService>().Get(q);
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public bool Delete(Guid q)
        {
            using (var scope = _collection.CreateScope())
            {
                return _collection.GetService<IPersonService>().Delete(q);
            }
        }
    }
}
