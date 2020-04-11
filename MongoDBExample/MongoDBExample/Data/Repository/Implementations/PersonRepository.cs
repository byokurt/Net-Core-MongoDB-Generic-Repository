using MongoDBExample.Data.Repository.Abstractions;
using MongoDBExample.Entities.BusinessEntities;

namespace MongoDBExample.Data.Repository.Implementations
{
    public class PersonRepository : BaseRepository<Person, int>, IPersonRepository
    {
        private readonly MongoDBContext _context;

        public PersonRepository(MongoDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
