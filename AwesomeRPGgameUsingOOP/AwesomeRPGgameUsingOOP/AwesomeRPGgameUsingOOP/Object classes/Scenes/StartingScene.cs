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


namespace AwesomeRPGgameUsingOOP.Scenes
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class StartingScene : Microsoft.Xna.Framework.GameComponent
    {
        private byte Choice { get; set; }
        
        public StartingScene(Game game)
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

            base.Initialize();
            this.Choice = 0;



        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);

            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Up))
            {
                if (this.Choice == 1)
                {
                    this.Choice = 0;
                }
                if (this.Choice == 0)
                {
                    this.Choice = 1;
                }
            }

            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Down))
            {
                if (this.Choice == 1)
                {
                    this.Choice = 0;
                }
                if (this.Choice == 0)
                {
                    this.Choice = 1;
                }
            }
            
                        

            Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Left);
            Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right);

            // play
            // help
        }
    }
}
