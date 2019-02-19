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

        // public Dictionary<string, Dictionary<string, string>> userData = new Dictionary<string, Dictionary<string, string>>();

        public string fileName;
        public dynamic userData;

        public void CreateUser(string userName)
        {
            fileName = String.Format(@"..\..\Data\Users\{0}.json", userName);
            userData = LoadJson(fileName);

            // var buffer = File.ReadAllLines(file).ToList();
            // int count = 0;
            // foreach (var line in buffer.Select(temp => temp.Split(',')))
            // {
            //     userData.Add(line[0], new Dictionary<string, string> {
            //         { "value", line[1] },
            //         { "line", count.ToString() }
            //     });
            //     count++;
            // }
        }
    }
}