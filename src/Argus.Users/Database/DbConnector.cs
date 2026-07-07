namespace Argus.Users.Database;

using System;
using DotNetEnv;

public class DbConnector
{
    private static readonly string? Host;

    private static readonly string? Port;

    private static readonly string? Database;

    private static readonly string? Username;

    private static readonly string? Password;

    static DbConnector()
    {
        Env.TraversePath().Load();

        Host = Environment.GetEnvironmentVariable("HOST_ADDRESS");
        Port = Environment.GetEnvironmentVariable("POSTGRES_PORT");
        Database = Environment.GetEnvironmentVariable("POSTGRES_DB");
        Username = Environment.GetEnvironmentVariable("POSTGRES_USER");
        Password = Environment.GetEnvironmentVariable("POSTGRES_PASSWORD");
    }

    public static string? ConnectionString
    {
        get =>  $"Host={Host};Port={Port};Database={Database};Username={Username};Password={Password}";
    }
}