using Argus.Users.Migrations;
using Microsoft.Extensions.DependencyInjection;

namespace Argus.Users.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddArgusUsers(this IServiceCollection services, string connectionString)
    {
        MigrationRunner.Run(connectionString);

        return services;
    }
}
