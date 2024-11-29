namespace WarehouseSecuriryInfrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using WarehouseSecurityApplication.Contract;
using WarehouseSecuriryInfrastructure.Repository;

public static class ConnectDb
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        try
        {
            var mysqlconnstr = configuration.GetConnectionString("ConnectionStrings");
            System.Console.WriteLine(mysqlconnstr);
            services.AddDbContext<SecurityContext>(
                dbContextOption => dbContextOption.UseMySql(mysqlconnstr,ServerVersion.AutoDetect(mysqlconnstr))
            );
            services.AddScoped<ISecurityRepository , securityRepository>();

        }catch(Exception error){
            System.Console.WriteLine(error);
        }
        return services;
    }
}
