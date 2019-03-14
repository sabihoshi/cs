using System.Collections.Generic;

namespace Library.Classes
{
	public class RootUsers
	{
		public List<User> Users { get; set; }
	}

	public class User
	{
		public User(string username, string password)
		{
			Username = username;
			Password = password;
		}

		public string Username { get; set; }
		public string Password { get; set; }
	}
}