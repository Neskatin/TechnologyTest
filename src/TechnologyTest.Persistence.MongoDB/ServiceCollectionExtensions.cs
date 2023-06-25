using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechnologyTest.Persistence.MongoDB;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectMongoDb(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
}