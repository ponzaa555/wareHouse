namespace WarehouseSecuriryInfrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

public static class ConnectDb
{
    public static IServiceCollection ConnectDbInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        try
        {
            var mysqlconnstr = configuration.GetConnectionString("ConnectionString");
            System.Console.WriteLine(mysqlconnstr);
            services.AddDbContext<SecurityContext>(
                dbContextOption => dbContextOption.UseMySql(mysqlconnstr,ServerVersion.AutoDetect(mysqlconnstr))
            );

        }catch(Exception error){
            System.Console.WriteLine(error);
        }
        return services;
    }
}
