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
            this.Armour = rnd.Next(20);
            this.Health = rnd.Next(30);
            this.Value = rnd.Next(100);
        }
    }
}
