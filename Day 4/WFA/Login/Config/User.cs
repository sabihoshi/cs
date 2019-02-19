using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Login
{
    public class User
    {
        public Dictionary<string, Dictionary<string, string>> userData = new Dictionary<string, Dictionary<string, string>>();
        public string file;

        public void CreateUser(string userName)
        {
            string file = String.Format(@"..\..\Data\Users\{0}.txt", userName);
            var buffer = File.ReadAllLines(file).ToList();
            int count = 0;
            foreach (var line in buffer.Select(temp => temp.Split(',')))
            {
                userData.Add(line[0], new Dictionary<string, string> {
                    { "value", line[0] },
                    { "line", count.ToString() }
                });
                count++;
            }
        }
    }
}