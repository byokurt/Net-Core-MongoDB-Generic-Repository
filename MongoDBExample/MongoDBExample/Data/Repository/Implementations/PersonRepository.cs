using MongoDBExample.Data.Repository.Abstractions;
using MongoDBExample.Entities.BusinessEntities;
using System;

namespace MongoDBExample.Data.Repository.Implementations
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(IMongoDBContext context) : base(context)
        {

        }
    }
}
