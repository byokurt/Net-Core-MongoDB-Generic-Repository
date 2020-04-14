using MongoDBExample.Data.Repository.Abstractions;
using MongoDBExample.Entities.BusinessEntities;
using MongoDBExample.Entities.ClientEntities.Response;
using NSubstitute;
using NUnit.Framework;
using System;
using Microsoft.Extensions.DependencyInjection;
using MongoDBExample.Business.Implementations;

namespace NUnitTestProjectExample
{
    [TestFixture]
    [Category("UnitTests.PersonServiceTest")]
    public class PersonServiceTest
    {
        IServiceProvider _serviceProvider;

        [SetUp]
        public void Setup()
        {
            _serviceProvider = Substitute.For<IServiceProvider>();
        }

        [Test]
        public void AddPersonService_HappyPath()
        {
            var PersonRepository = Substitute.For<IPersonRepository>();

            var request = Guid.NewGuid();

            #region Model
            var getPersonResponse = new GetPersonResponse();
            getPersonResponse.FirstName = "Osman";
            getPersonResponse.LastName = "KURT";
            getPersonResponse.BirthDate = DateTime.Now;

            var personResponse = new Person();
            personResponse.FirstName = "Osman";
            personResponse.LastName = "KURT";
            personResponse.BirthDate = DateTime.Now;
            #endregion


            PersonRepository.GetById(request).Returns(personResponse);
            _serviceProvider.GetService<IPersonRepository>().Returns(PersonRepository);

            var personService = new PersonService(_serviceProvider);

            Assert.True(personService.Get(request) != null);

        }
    }
}