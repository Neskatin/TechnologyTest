using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechnologyTest.Persistence.FaunaDB;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectFaunaDb(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
}