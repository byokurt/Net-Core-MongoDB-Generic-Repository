using MongoDBExample.Entities.ClientEntities;
using System;

namespace MongoDBExample.Business.Abstractions
{
    public interface IPersonService
    {
        bool Add(AddPersonRequest request);

        bool Get(Guid request);

        bool Delete(Guid request);
    }
}
