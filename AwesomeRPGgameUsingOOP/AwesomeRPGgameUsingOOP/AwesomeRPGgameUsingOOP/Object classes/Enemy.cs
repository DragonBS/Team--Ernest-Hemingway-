﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes
{
    public class Enemy:Character
    {
        public int HealthOfEnemy { get; set; }
        public int ArmourOfEnemy { get; set; }
        public int DamageOfEnemy { get; set; }
        public List<Item> Items { get; set; } 
    }
}
