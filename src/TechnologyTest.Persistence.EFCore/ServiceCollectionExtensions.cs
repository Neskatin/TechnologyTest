using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechnologyTest.Persistence.EFCore;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectEfCore(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
}