using Microsoft.Extensions.DependencyInjection;
using MongoDBExample.Business.Abstractions;
using MongoDBExample.Business.Implementations;

namespace MongoDBExample.Business
{
    public static class ServicesExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>();
        }
    }
}
