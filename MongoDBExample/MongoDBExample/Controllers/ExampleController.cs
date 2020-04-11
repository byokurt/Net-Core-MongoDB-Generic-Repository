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

        [HttpGet]
        [Route("Add")]
        public bool Add(AddPersonRequest request)
        {
            return _collection.GetService<IPersonService>().Add(request);
        }
    }
}
