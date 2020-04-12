using System;
using Microsoft.Extensions.DependencyInjection;
using MongoDBExample.Business.Abstractions;
using MongoDBExample.Data.Repository.Abstractions;
using MongoDBExample.Entities.BusinessEntities;
using MongoDBExample.Entities.ClientEntities;
using MongoDBExample.Entities.ClientEntities.Request;
using MongoDBExample.Entities.ClientEntities.Response;

namespace MongoDBExample.Business.Implementations
{
    public class PersonService : IPersonService
    {
        private readonly IServiceProvider _collection;

        public PersonService(IServiceProvider collection)
        {
            _collection = collection;
        }

        public bool Add(AddPersonRequest request)
        {
            Person entity = new Person();
            entity.BirthDate = request.BirthDate;
            entity.FirstName = request.FirstName;
            entity.LastName = request.LastName;
            entity.CreateDate = DateTime.Now;

            var person = _collection.GetService<IPersonRepository>().Add(entity);

            return person != null ? true : false;
        }

        public GetPersonResponse Get(Guid request)
        {
            GetPersonResponse response = new GetPersonResponse();

            var person = _collection.GetService<IPersonRepository>().GetById(request);

            if (person != null)
            {
                response.Id = person.Id;
                response.FirstName = person.FirstName;
                response.LastName = person.LastName;
                response.BirthDate = person.BirthDate;
            }
            return response;
        }

        public bool Delete(Guid request)
        {
            _collection.GetService<IPersonRepository>().Remove(request);
            return true;
        }
    }
}
