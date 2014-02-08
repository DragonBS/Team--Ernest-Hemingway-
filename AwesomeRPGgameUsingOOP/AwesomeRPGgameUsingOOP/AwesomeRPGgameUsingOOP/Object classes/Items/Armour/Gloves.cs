using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes.Items
{
    class Gloves:Armour
    {

        public Gloves()
        {
            this.Type = ArmorType.Gloves;
        }
        public Gloves generateArmour()
        {
            Gloves result = new Gloves();
            result.Armour = rnd.Next(20);
            result.Health = rnd.Next(30);
            result.Value = rnd.Next(100);
            return result;
        }
    }
}
