using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes.Items
{
    internal enum ArmorType
{
        Helm,Body,Gloves,Boots
};
    class Armour:Item
    {

        public ArmorType Type{get;set;}
        
    }
}
