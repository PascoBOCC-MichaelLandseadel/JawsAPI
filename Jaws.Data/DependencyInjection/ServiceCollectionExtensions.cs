using Jaws.Data.Context;
using Jaws.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Jaws.Data.DependencyInjection;

/// <summary>
/// Registration helpers for the JAWS data layer. Call from an app''s
/// composition root (e.g., Program.cs) to wire up the DbContext and repositories.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers <see cref="JawsDbContext"/> and data repositories.
    /// Connection string comes from configuration key "ConnectionStrings:JawsDb"
    /// (store it in user secrets / environment variables - never in source).
    /// </summary>
    public static IServiceCollection AddJawsData(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("JawsDb")
            ?? throw new InvalidOperationException("Connection string ''JawsDb'' was not found in configuration.");

        services.AddDbContext<JawsDbContext>(options => options.UseSqlServer(connectionString));
        services.AddScoped<ICaseRepository, CaseRepository>();
        services.AddScoped<IUserRoleRepository, UserRoleRepository>();

        return services;
    }
}