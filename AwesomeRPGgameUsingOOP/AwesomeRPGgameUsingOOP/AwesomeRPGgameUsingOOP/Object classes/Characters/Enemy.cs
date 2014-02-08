using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AwesomeRPGgameUsingOOP.Object_classes
{
    public class Enemy:Character
    {
        internal static Random rand = new Random();
        public Texture2D EnemyTexture { get; set; }
        public Vector2 EnemyVector { get; set; }


        public Enemy()
        {
            this.IsAlive = true;
            this.Health = rand.Next(70, 120);
            this.Armour = rand.Next(0, 25);
            this.Damage = rand.Next(15, 50);
            this.Gold = rand.Next(50);
            this.Experience = rand.Next(5, 20);
        }
    }
}
