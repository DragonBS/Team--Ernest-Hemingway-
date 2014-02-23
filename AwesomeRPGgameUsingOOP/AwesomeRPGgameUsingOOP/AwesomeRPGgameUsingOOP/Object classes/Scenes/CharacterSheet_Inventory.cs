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
        Hero hero;
        internal int placeInInventory;
        internal int row;
        internal int column;
        internal float gamepassed;
        internal float timer;
        internal const float DELAY = 0.15f;
        internal Item item;
        internal static int inventorX = 357;
        internal static int inventorY = 177;
        internal static int intervalROW = 0;
        internal static int intervalCOL = 0;

        private Texture2D itemPic;
        private Texture2D itemFrame;
        private Texture2D inventory;

        private SpriteFont inventoryFont;

        public CharacterSheet_Inventory(Game game)
            : base(game)
        {
            
            hero = new Hero();
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
            inventory = content.Load<Texture2D>("inventory");
            inventoryFont = content.Load<SpriteFont>("SpriteFont1");
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

            #endregion

            item = hero.Items[placeInInventory];
            base.Update(gameTime);
        }

        private void GetItemStatistics(out string health, out string damage, out string armor)
        {
            string nan = "N/A";
            health = nan;
            damage = nan;
            armor = nan;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            
            spriteBatch.Begin();
            spriteBatch.Draw(inventory, new Vector2(0, 0), Color.White);
            
            if (item == null)
            {
                spriteBatch.DrawString(inventoryFont, "0", new Vector2(250, 225), Color.Black, 0, new Vector2(0, 0), 1.35f, new SpriteEffects(), 0f);
                spriteBatch.DrawString(inventoryFont, "0", new Vector2(250, 298), Color.Black, 0, new Vector2(0, 0), 1.35f, new SpriteEffects(), 0f);
                spriteBatch.DrawString(inventoryFont, "0", new Vector2(250, 374), Color.Black, 0, new Vector2(0, 0), 1.35f, new SpriteEffects(), 0f);
            }
            else
            {
                spriteBatch.DrawString(inventoryFont, item.Damage.ToString(), new Vector2(250, 225), Color.Black, 0, new Vector2(0, 0), 1.35f, new SpriteEffects(), 0f);
                spriteBatch.DrawString(inventoryFont, item.Armour.ToString(), new Vector2(250, 298), Color.Black, 0, new Vector2(0, 0), 1.35f, new SpriteEffects(), 0f);
                spriteBatch.DrawString(inventoryFont, item.Health.ToString(), new Vector2(250, 374), Color.Black, 0, new Vector2(0, 0), 1.35f, new SpriteEffects(), 0f);
                
            }
            for (int i = 0; i < 4; i++) // rows
            {
                intervalROW = 0;
                intervalCOL = 10;
                for (int j = 0; j < 4; j++) // columns
                {
                    intervalCOL = i * 10 + 10;
                    spriteBatch.Draw(itemPic, new Vector2(i * 64 + inventorX + intervalCOL, j * 64 + inventorY + intervalROW), Color.White);
                    intervalROW = j * 10+10;
                   
                    if ((i == column) && (j == row))
                    {
                       spriteBatch.Draw(itemFrame, new Vector2(i * 64 + inventorX + intervalCOL, j * 64 + inventorY + intervalROW-10), Color.White);
                    }
                }
            }

            spriteBatch.DrawString(inventoryFont, "Damage: ", new Vector2(130, 225), Color.Black, 0, new Vector2(0, 0), 1.35f, new SpriteEffects(), 0f);
            spriteBatch.DrawString(inventoryFont, "Armour: ", new Vector2(130, 298), Color.Black, 0, new Vector2(0, 0), 1.35f, new SpriteEffects(), 0f);
            spriteBatch.DrawString(inventoryFont, "Health: ", new Vector2(130, 374), Color.Black, 0, new Vector2(0, 0), 1.35f, new SpriteEffects(), 0f);
            spriteBatch.End();

            //base.Draw(gameTime);
        } 
    }
}
