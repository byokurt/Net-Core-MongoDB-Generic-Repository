using MongoDBExample.Entities.ClientEntities;

namespace MongoDBExample.Business.Abstractions
{
    public interface IPersonService
    {
        bool Add(AddPersonRequest request);
    }
}
