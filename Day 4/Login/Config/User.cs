using Newtonsoft.Json;
using System;
using System.IO;

namespace Login
{
    public class User
    {
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

        public string fileName;
        public dynamic userData;

        public void CreateUser(string userName)
        {
            fileName = String.Format(@"..\..\Data\Users\{0}.json", userName);
            userData = LoadJson(fileName);
        }
    }
}