using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechnologyTest.Persistence.Redis;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectRedis(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
}