using MongoDBExample.Data.Repository.Abstractions;
using MongoDBExample.Entities.BusinessEntities;
using MongoDBExample.Entities.ClientEntities.Response;
using NSubstitute;
using NUnit.Framework;
using System;
using Microsoft.Extensions.DependencyInjection;
using MongoDBExample.Business.Implementations;
using FizzWare.NBuilder;

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

            var personResponse = Builder<Person>.CreateNew().Build();

            PersonRepository.GetById(request).Returns(personResponse);
            _serviceProvider.GetService<IPersonRepository>().Returns(PersonRepository);

            var personService = new PersonService(_serviceProvider);

            Assert.True(personService.Get(request) != null);

        }
    }
}