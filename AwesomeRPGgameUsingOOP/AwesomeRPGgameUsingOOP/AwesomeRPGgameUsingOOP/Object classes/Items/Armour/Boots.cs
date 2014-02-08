using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes.Items
{
    class Boots:Armour
    {

        public Boots()
        {
            this.Type = ArmorType.Boots;
        }
        public Boots generateArmour()
        {
            Boots result = new Boots();
            result.Armour = rnd.Next(15);
            result.Health = rnd.Next(20);
            result.Value = rnd.Next(50);
            return result;
        }
    }
}
