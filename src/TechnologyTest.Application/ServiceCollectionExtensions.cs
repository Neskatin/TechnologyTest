using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechnologyTest.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectApplication(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
}