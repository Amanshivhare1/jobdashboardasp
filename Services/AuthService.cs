using JobDashboard.Models;
using System.Collections.Generic;
using System.Linq;

public class AuthService
{
    // Replace with DB logic
    private List<User> _users = new List<User>
    {
        new User { Username = "admin", Password = "admin123", Role = "admin" },
        new User { Username = "viewer", Password = "viewer123", Role = "viewer" }
    };

    public User Authenticate(string username, string password)
    {
        return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
    }
}
