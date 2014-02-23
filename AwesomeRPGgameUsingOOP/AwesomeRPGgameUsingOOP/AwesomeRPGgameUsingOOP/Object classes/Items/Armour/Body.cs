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
            this.Armour = rnd.Next(25);
            this.Health = rnd.Next(50);
            this.Value = rnd.Next(100);
        }
       
    }
}
