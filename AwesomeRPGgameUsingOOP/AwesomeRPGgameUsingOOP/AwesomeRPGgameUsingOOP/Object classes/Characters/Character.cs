using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes
{
    public abstract class Character
    {
       //private int health;
       //private int armour;
       //private int damage;
       //private bool isAlive;
       //private List<Item> items;

       public int Health { get; set; }
       public int Armour { get; set; }
       public int Damage { get; set; }
       public bool IsAlive { get; set; }
       public List<Item> Items { get; set; }
       public int Gold { get; set; }
       public int Experience { get; set; }

        internal int DealDamage(int DamageAttacker, int ArmourDefender)
        {
            int result = DamageAttacker-ArmourDefender;
            if (result<=0)
            {
                return 0;
            }
            else
            {
                return result;
            }
        }

        public void TakeDamage(Character attacker,ref Character defender)
        {
                defender.Health = defender.Health - DealDamage(attacker.Damage, defender.Armour);
                if (defender.Health<=0)
                {
                    defender.IsAlive = false;
                }
        }

     }
}
