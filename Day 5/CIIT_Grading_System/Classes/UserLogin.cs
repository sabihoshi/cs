using System.Collections.Generic;

namespace CIIT_Grading_System.Classes
{
    public partial class UserLogins
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public partial class Users
    {
        public List<UserLogins> User = new List<UserLogins>();
    }
}