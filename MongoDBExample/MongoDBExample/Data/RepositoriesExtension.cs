using MongoDBExample.Data.Repository.Abstractions;
using MongoDBExample.Data.Repository.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace MongoDBExample.Data
{
    public static class RepositoriesExtension
    {
        public static void RegisterRepos(this IServiceCollection services)
        {
            services.AddTransient<IPersonRepository, PersonRepository>();
        }
    }
}
