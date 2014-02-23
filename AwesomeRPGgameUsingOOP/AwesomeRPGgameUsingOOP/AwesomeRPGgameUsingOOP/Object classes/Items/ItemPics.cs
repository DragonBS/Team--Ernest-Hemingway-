using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace AwesomeRPGgameUsingOOP.Object_classes.Items
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public static class ItemPics // : Microsoft.Xna.Framework.GameComponent
    {
        public static Texture2D WeaponPic;
        public static Texture2D BodyPic;
        public static Texture2D GlovesPic;
        public static Texture2D BootsPic;
        public static Texture2D HelmPic;

      
        public static void LoadContent(ContentManager content)
        {
            // Create a new SpriteBatch, which can be used to draw textures.

            // TODO: use this.Content to load your game content here

            WeaponPic = content.Load<Texture2D>("item");
            GlovesPic = content.Load<Texture2D>("Gloves");
            BootsPic = content.Load<Texture2D>("boots");
            HelmPic = content.Load<Texture2D>("Helm");
            BodyPic = content.Load<Texture2D>("Chest");

        }
        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
     
    }
}
