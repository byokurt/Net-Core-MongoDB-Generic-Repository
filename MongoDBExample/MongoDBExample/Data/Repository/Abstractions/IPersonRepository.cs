using MongoDBExample.Entities.BusinessEntities;

namespace MongoDBExample.Data.Repository.Abstractions
{
    public interface IPersonRepository : IBaseRepository<Person, int>
    {

    }
}
