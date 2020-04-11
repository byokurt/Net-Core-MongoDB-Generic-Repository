using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDBExample.Entities.BusinessEntities.Base
{
    public interface IDocument<IdType>
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        IdType Id { get; set; }

        DateTime CreateDate { get; }
    }
}
