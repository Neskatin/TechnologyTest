using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechnologyTest.Persistence.RavenDB;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectRavenDb(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
}