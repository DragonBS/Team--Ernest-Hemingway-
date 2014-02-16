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
using AwesomeRPGgameUsingOOP.Object_classes.Items;


namespace AwesomeRPGgameUsingOOP.Object_classes.Scenes
{

    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class CharacterSheet_Inventory : Microsoft.Xna.Framework.GameComponent
    {
        internal int placeInInventory;
        internal int row;
        internal int column;
        internal float gamepassed;
        internal float timer;
        internal const float DELAY = 0.15f;

        internal static int inventor = 100;
        private Texture2D itemPic;
        private Texture2D itemFrame;


        public CharacterSheet_Inventory(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here
            placeInInventory = 0;
            row = 0;
            column = 0;
            timer = DELAY;

            base.Initialize();
        }

        public void LoadContent(ContentManager content)
        {
            // Create a new SpriteBatch, which can be used to draw textures.

            // TODO: use this.Content to load your game content here

            itemPic = content.Load<Texture2D>("item");
            itemFrame = content.Load<Texture2D>("frame");
        }
        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            gamepassed = (float)gameTime.ElapsedGameTime.TotalSeconds;
            timer = timer - gamepassed;
            // TODO: Add your update code here
            #region Controls
            if (timer < 0)
            {
                timer = DELAY;
                if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Down))
                {
                    if (placeInInventory <= 11)
                    {
                        placeInInventory = placeInInventory + 4;
                        row++;
                    }
                    else
                    {
                        placeInInventory = placeInInventory - 11;
                        row = 0;
                    }
                }
                if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Up))
                {
                    if (placeInInventory > 3)
                    {
                        placeInInventory = placeInInventory - 4;
                        row--;
                    }
                    else
                    {
                        placeInInventory = placeInInventory + 11;
                        row = 3;
                    }
                }
                if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Left))
                {
                    if ((placeInInventory != 0) && (placeInInventory % 4 != 0))
                    {
                        placeInInventory = placeInInventory - 1;
                        column--;
                    }
                    else
                    {
                        placeInInventory = placeInInventory + 3;
                        column = 3;
                    }
                }
                if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right))
                {
                    if ((placeInInventory != 3) && (placeInInventory != 7) && (placeInInventory != 11) && (placeInInventory != 15))
                    {
                        placeInInventory = placeInInventory + 1;
                        column++;
                    }
                    else
                    {
                        placeInInventory = placeInInventory - 3;
                        column = 0;
                    }
                }


            }

            #endregion

            base.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here


            spriteBatch.Begin();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    spriteBatch.Draw(itemPic, new Vector2(i * 64 + inventor, j * 64 + inventor), Color.White);
                    if ((i == column) && (j == row))
                    {
                        spriteBatch.Draw(itemFrame, new Vector2(i * 64 + inventor, j * 64 + inventor), Color.White);
                    }
                }
            }

            spriteBatch.End();

            //base.Draw(gameTime);
        }
    }
}
