﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes
{
    public abstract class Character
    {
       public int Health { get; set; }
       public int Armor { get; set; }
       public int Damage { get; set; }
       public bool IsAlive { get; set; }
    }
}
