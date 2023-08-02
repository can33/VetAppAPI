using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace VetAppAPI.Application;

public static class ServiceRegistration
{
    public static void AddApplicationRegistration(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddMediatR(x => x.RegisterServicesFromAssembly(assembly));
    }
}
