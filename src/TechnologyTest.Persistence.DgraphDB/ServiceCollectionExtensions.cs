using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechnologyTest.Persistence.DgraphDB;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectDgraphDb(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
}