using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Classes
{
    internal class Player
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public Inventory Bag { get; set; }

        public Player(string name, int health)
        {
            Name = name;
            Health = health;
        }
    }

    internal class Inventory
    {
        public int Quantity { get; set; }
        public int Remaining => Quantity - InventoryList.Count;
        public List<string> InventoryList { get; set; }
    }
}