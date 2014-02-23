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
            this.Armour = rnd.Next(35);
            this.Health = rnd.Next(20);
            this.Value = rnd.Next(100);
        }
    }
}
