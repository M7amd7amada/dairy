using Dairy.DataAccess.Data;
using Dairy.Domain.Common.Settings;

using Microsoft.EntityFrameworkCore;

namespace Dairy.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddControllers();

        services.Configure<AppSettingsOptions>
            (configuration.GetSection(AppSettingsOptions.AppSettings));

        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

        return services;
    }
}