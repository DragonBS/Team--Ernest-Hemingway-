using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes
{
    public class Hero: Character
    {
        public int FreeInventory { get; set; }
        public int HealthOfHero { get; set; }
        public int ArmourOfHero { get; set; }
        public int DamageOfHero { get; set; }
        public List<Item> Items { get; set; } 
    }
}
