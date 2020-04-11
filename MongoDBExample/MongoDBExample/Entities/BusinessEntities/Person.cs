using MongoDBExample.Data;
using MongoDBExample.Entities.BusinessEntities.Base;
using System;

namespace MongoDBExample.Entities.BusinessEntities
{
    [BsonCollection("people")]
    public class Person : BaseEntity<int>
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
