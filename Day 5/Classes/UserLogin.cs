using System.Collections.Generic;

namespace CIIT_Grading_System.Classes
{
    public partial class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserLogin(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }

    public partial class Users
    {
        public List<UserLogin> User = new List<UserLogin>();
    }
}