using System;
using Microsoft.Extensions.DependencyInjection;
using MongoDBExample.Business.Abstractions;
using MongoDBExample.Data.Repository.Abstractions;
using MongoDBExample.Entities.BusinessEntities;
using MongoDBExample.Entities.ClientEntities;

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

        public bool Get(Guid request)
        {
            var person = _collection.GetService<IPersonRepository>().GetById(request);
            return person != null ? true : false;
        }

        public bool Delete(Guid request)
        {
            _collection.GetService<IPersonRepository>().Remove(request);
            return true;
        }
    }
}
