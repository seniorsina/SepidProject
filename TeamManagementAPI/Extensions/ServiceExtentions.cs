

using Contracts;
using DataContext;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace TeamManagementAPI.Extensions;
public static class ServiceExtentions
{
    public static void ConfigureDbContext(this IServiceCollection services)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json").Build();
        services.AddDbContext<TeamDbContext>(opetions =>
        opetions.UseSqlServer(configuration.GetConnectionString("sqlConnection"), b => b.MigrationsAssembly("TeamManagementAPI")));
    }

    public static void ConfigureTeamRepository(this IServiceCollection services)
    {
        services.AddScoped<ITeamRepository, TeamRepository>();
    }

    public static void ConfigureSysListRepository(this IServiceCollection services)
    {
        services.AddScoped<ISysListRepository, SysListRepository>();
    }
}
