using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes.Items
{
    class Helm:Armour
    {

        public Helm()
        {
            this.Type = ArmorType.Helm;
        }
        public Helm generateArmour()
        {
            Helm result = new Helm();
            result.Armour = rnd.Next(35);
            result.Health = rnd.Next(20);
            result.Value = rnd.Next(100);
            return result;
        }
    }
}
