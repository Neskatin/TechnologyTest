using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechnologyTest.Persistence.Firestore;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddProjectFirestore(this IServiceCollection services, IConfiguration config)
    {
        return services;
    }
}