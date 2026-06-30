namespace Argus.Users.Models;

public class User
{
    public long Id {get; private set;}

    public string? Email {get; private set;}

    public string? Username {get; private set;}

    public string? Password {get; private set;}

    public static User Create(string Email, string Username, string Password)
    {
        
        return new User{
            Email = Email,
            Username = Username,
            Password = Password
        };
        
    }
}