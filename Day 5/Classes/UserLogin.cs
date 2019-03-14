using System.Collections.Generic;

namespace CIIT_Grading_System.Classes
{
	public class UserLogin
	{
		public UserLogin(string username, string password)
		{
			Username = username;
			Password = password;
		}

		public string Username { get; set; }
		public string Password { get; set; }
	}

	public class Users
	{
		public List<UserLogin> User = new List<UserLogin>();
	}
}