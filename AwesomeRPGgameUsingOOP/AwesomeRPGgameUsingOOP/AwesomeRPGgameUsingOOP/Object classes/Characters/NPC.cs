using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AwesomeRPGgameUsingOOP.Object_classes
{
    public class NPC:Character
    {
        public Texture2D NPCTexture { get; set; }
        public Vector2 NPCVector { get; set; }
        
        public NPC()
        {
            this.IsAlive = true;
        }

     
    }
}
