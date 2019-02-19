using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Login
{
    internal class User
    {
        public Dictionary<string, string> userData = new Dictionary<string, string>();

        public void CreateUser(string userName)
        {
            string file = String.Format(@"..\..\Data\Users\{0}.txt", userName);
            var buffer = File.ReadAllLines(file).ToList();
            foreach (var line in buffer.Select(temp => temp.Split(',')))
            {
                userData.Add(line[0], line[1]);
            }
        }
    }
}