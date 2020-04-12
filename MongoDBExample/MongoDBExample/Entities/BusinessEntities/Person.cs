using MongoDBExample.Data;
using MongoDBExample.Entities.BusinessEntities.Base;
using System;

namespace MongoDBExample.Entities.BusinessEntities
{
    [BsonCollection("people")]
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
