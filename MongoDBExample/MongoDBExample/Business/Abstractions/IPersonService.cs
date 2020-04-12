using MongoDBExample.Entities.ClientEntities.Request;
using MongoDBExample.Entities.ClientEntities.Response;
using System;

namespace MongoDBExample.Business.Abstractions
{
    public interface IPersonService
    {
        bool Add(AddPersonRequest request);

        GetPersonResponse Get(Guid request);

        bool Delete(Guid request);
    }
}
