using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes.Items
{
    class Weapon:Item
    {
        public int HandsUsed { get; set; }

        public Weapon generateWeapon()
        {
            Weapon result = new Weapon();
            result.Damage = Item.rnd.Next();
            result.Value = rnd.Next();
            return result;
        }
    }
}
