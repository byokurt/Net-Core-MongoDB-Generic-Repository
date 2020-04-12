using MongoDBExample.Data.Repository.Abstractions;
using MongoDBExample.Entities.BusinessEntities;

namespace MongoDBExample.Data.Repository.Implementations
{
    public class PersonRepository : BaseRepository<Person, int>, IPersonRepository
    {
       

        public PersonRepository(IMongoDBContext context) : base(context)
        {
           
        }
    }
}
