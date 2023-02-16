using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Infrastructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureService(this IServiceCollection services)
    {
        return services;
    }
}
