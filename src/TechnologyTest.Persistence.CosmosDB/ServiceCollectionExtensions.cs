using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechnologyTest.Persistence.CosmosDB;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectCosmosDb(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
}