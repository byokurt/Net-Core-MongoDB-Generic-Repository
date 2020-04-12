using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDBExample.Helpers;

namespace MongoDBExample.Data
{
    public class IMongoDBContext
    {
        IMongoDatabase _db { get; }
        MongoClient _mongoClient { get; }
    }
}
