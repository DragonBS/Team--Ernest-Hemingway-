using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes
{
   abstract public class Item
    {
        public string ItemName { get; set; }
        public int Health { get; set; }
        public int Armour { get; set; }
        public int Damage { get; set; }
        public int Value { get; set; }
        protected static Random rnd=new Random(10);

       

    }
}
