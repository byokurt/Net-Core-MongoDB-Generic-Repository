using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDBExample.Helpers;

namespace MongoDBExample.Data
{
    public interface IMongoDBContext
    {
        IMongoDatabase _db { get; }
        MongoClient _mongoClient { get; }
        IMongoCollection<T> GetCollection<T>(string name);
    }
}
