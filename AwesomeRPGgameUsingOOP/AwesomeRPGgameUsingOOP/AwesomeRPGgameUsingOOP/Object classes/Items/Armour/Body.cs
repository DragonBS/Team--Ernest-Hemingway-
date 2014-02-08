using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes.Items
{
    class Body:Armour
    {
        public Body()
        {
            this.Type = ArmorType.Body;
        }
        public Body generateArmour()
        {
            Body result = new Body();
            result.Armour = rnd.Next(25);
            result.Health = rnd.Next(50);
            result.Value = rnd.Next(100);
            return result;
        }
    }
}
