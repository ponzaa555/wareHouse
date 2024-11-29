using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace WarehouseSecurityApplication;

public static class RegisterApplication
{
    public static IServiceCollection AddRegisterApplication(this IServiceCollection services)
    {
        services.AddMediatR(config => {
            config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        return services;
    }
}
