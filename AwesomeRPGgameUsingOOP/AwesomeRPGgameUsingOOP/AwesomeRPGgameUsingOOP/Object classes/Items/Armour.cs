using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes.Items
{
    internal enum ArmorType
{
        Head,Body,Hands,Feets
};
    class Armour:Item
    {

        public ArmorType Type{get;set;}
        public Armour generateArmour()
        {
            Armour result = new Armour();
            result.Armour = rnd.Next();
            result.Health = rnd.Next();
            result.Value = rnd.Next();
            return result;
        }
    }
}
