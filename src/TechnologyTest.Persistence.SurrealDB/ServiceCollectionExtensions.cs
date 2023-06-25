using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechnologyTest.Persistence.SurrealDB;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectSurrealDb(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
}