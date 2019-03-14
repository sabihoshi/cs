using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Classes;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var players = new List<Player>();

            void OutputObject(object obj)
            {
                Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented));
            }
            string AskUser(string question)
            {
                Console.WriteLine(question);
                return Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                players.Add(new Player(AskUser($"What name would you like for player {i}?"), int.Parse(AskUser("Health"))));
            }

            var healthy = players.Where(p => p.Health > 50);
            OutputObject(healthy);
        }
    }
}