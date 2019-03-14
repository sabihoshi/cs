using System;
using System.IO;
using Newtonsoft.Json;

namespace Login
{
	public class User
	{
		public dynamic userData;

		public string userFile;

		public void JsonUpdate(string fileName, dynamic new_object)
		{
			using (StreamWriter file = File.CreateText(fileName))
			{
				var serializer = new JsonSerializer();
				serializer.Serialize(file, new_object);
			}
		}

		public dynamic LoadJson(string file)
		{
			using (var r = new StreamReader(file))
			{
				string json = r.ReadToEnd();
				dynamic array = JsonConvert.DeserializeObject(json);
				foreach (dynamic item in array) Console.WriteLine("{0}", item);
				return array;
			}
		}

		public void CreateUser(string userName)
		{
			userFile = string.Format(@"..\..\Data\Users\{0}.json", userName);
			userData = LoadJson(userFile);
		}
	}
}