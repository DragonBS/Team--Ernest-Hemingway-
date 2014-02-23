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
            this.Armour = rnd.Next(15);
            this.Health = rnd.Next(20);
            this.Value = rnd.Next(50);
        }
     }
}
