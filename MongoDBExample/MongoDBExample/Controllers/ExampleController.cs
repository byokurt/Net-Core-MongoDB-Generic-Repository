using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using MongoDBExample.Business.Abstractions;
using MongoDBExample.Entities.ClientEntities;

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
        public bool Get(Guid request)
        {
            using (var scope = _collection.CreateScope())
            {
                return _collection.GetService<IPersonService>().Get(request);
            }
        }

        [HttpGet]
        [Route("Delete")]
        public bool Delete(Guid request)
        {
            using (var scope = _collection.CreateScope())
            {
                return _collection.GetService<IPersonService>().Delete(request);
            }
        }
    }
}
