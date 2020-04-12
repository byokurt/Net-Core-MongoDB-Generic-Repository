using System;

namespace MongoDBExample.Entities.ClientEntities.Request
{
    public class AddPersonRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
