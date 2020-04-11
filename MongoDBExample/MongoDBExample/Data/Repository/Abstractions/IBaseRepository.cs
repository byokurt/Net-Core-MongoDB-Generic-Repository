using MongoDBExample.Entities.BusinessEntities.Base;
using System.Collections.Generic;

namespace MongoDBExample.Data.Repository.Abstractions
{
    public interface IBaseRepository<T, IdType> where T : IDocument<IdType>
    {
        T Add(T entity);
        T GetById(IdType id);
        void Remove(IdType id);
        IEnumerable<T> GetAll();
        void Update(T entity);
    }
}
