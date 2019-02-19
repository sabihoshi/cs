using Newtonsoft.Json;
using System;
using System.IO;

namespace Login
{
    public class User
    {
        public void JsonUpdate(string fileName, dynamic new_object)
        {
            using (StreamWriter file = File.CreateText(fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, new_object);
            }
        }

        public dynamic LoadJson(string file)
        {
            using (StreamReader r = new StreamReader(file))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                foreach (var item in array)
                {
                    Console.WriteLine("{0}", item);
                }
                return array;
            }
        }

        public string userFile;
        public dynamic userData;

        public void CreateUser(string userName)
        {
            userFile = String.Format(@"..\..\Data\Users\{0}.json", userName);
            userData = LoadJson(userFile);
        }
    }
}