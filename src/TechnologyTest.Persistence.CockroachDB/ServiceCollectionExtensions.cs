using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechnologyTest.Persistence.CockroachDB;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectCockroachDb(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
}