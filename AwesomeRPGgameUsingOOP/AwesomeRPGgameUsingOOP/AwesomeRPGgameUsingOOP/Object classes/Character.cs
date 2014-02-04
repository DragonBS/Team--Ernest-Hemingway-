using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes
{
    public abstract class Character
    {
       public int Health { get; set; }
       public int Armour { get; set; }
       public int Damage { get; set; }
       public bool IsAlive { get; set; }

        //HERO
       public int FreeInventory { get; set; }
       public int HealthOfHero{ get; set; }
       public int ArmourOfHero{ get; set; }
       public int DamageOfHero { get; set; }
       public List<Item> Items { get; set; } 


        //NPC
        override const bool IsAlive = true;
        public List<Item> Items { get; set; } 

        //ENEMY
        public int HealthOfEnemy { get; set; }
        public int ArmourOfEnemy { get; set; }
        public int DamageOfEnemy { get; set; }
        public List<Item> Items { get; set; } 
    }
}
