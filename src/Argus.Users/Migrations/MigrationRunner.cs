using DbUp;
using DbUp.Engine;

namespace Argus.Users.Migrations;

internal static class MigrationRunner
{
    internal static void Run(string connectionString)
    {
        EnsureDatabase.For.PostgresqlDatabase(connectionString);

        UpgradeEngine upgrader = DeployChanges.To
            .PostgresqlDatabase(connectionString)
            .WithScriptsEmbeddedInAssembly(
                typeof(MigrationRunner).Assembly,
                script => script.StartsWith("Argus.Users.Migrations.Scripts."))
            .WithTransactionPerScript()
            .JournalToPostgresqlTable("argus_users", "__migrations")
            .LogToConsole()
            .Build();

        DatabaseUpgradeResult result = upgrader.PerformUpgrade();

        if (!result.Successful)
            throw new Exception("Migration failed.", result.Error);
    }
}
