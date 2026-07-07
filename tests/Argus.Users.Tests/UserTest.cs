using Argus.Users.Models;
using Argus.Users.Database;
using System;
using System.Text.Json;
using Xunit.Abstractions;

public class UserTest(ITestOutputHelper output)
{
    [Fact]
    public void TestUserModelCreate()
    {
        var user = User.Create("mssfrc1@", "mssfrc1", "123456");
        output.WriteLine(JsonSerializer.Serialize(user));
    }

    [Fact]
    public void TestConnectionString()
    {
        output.WriteLine(DbConnector.ConnectionString);
    }
}