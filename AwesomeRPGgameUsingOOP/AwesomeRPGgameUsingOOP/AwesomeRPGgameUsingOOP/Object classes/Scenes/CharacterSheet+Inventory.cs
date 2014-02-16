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
        private bool InventoryIsOpen { get; set; }
        private Item[,] VisualiseInventory { get; set; }
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
            InventoryIsOpen = true;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                }
            }
            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            int placeInInventory = 0;
            // TODO: Add your update code here
            #region Controls
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Down))
            {
                if (placeInInventory <= 11)
                {
                    placeInInventory = placeInInventory + 4;
                }
                else
                {
                    placeInInventory = placeInInventory - 11;
                }
            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Up))
            {
                if (placeInInventory > 3)
                {
                    placeInInventory = placeInInventory - 4;
                }
                else
                {
                    placeInInventory = placeInInventory + 11;
                }
            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Left))
            {
                if ((placeInInventory != 0) && (placeInInventory % 4 != 0))
                {
                    placeInInventory = placeInInventory - 1;
                }
                else
                {
                    placeInInventory = placeInInventory + 3;
                }
            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right))
            {
                if ((placeInInventory != 3) && (placeInInventory != 7) && (placeInInventory != 11) && (placeInInventory != 15))
                {
                    placeInInventory = placeInInventory + 1;
                }
                else
                {
                    placeInInventory = placeInInventory - 3;
                }
            }
            #endregion

            base.Update(gameTime);
        }
        protected void Draw(GameTime gameTime)
        {
            // GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            // base.Draw(gameTime);
        }
    }
}
