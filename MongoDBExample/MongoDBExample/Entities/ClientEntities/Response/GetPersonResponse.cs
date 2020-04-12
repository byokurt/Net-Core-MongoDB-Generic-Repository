using System;

namespace MongoDBExample.Entities.ClientEntities.Response
{
    public class GetPersonResponse
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
