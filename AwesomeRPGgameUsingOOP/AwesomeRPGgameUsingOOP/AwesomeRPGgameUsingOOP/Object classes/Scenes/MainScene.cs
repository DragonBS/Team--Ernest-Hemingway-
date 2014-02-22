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
    public class MainScene : Microsoft.Xna.Framework.GameComponent
    {
        private Texture2D backgroundTexture;
        private Vector2 backgroundVector;

        private Texture2D playerTexture;
        private Vector2 playerVector;

        public MainScene(Game game)
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
        }

        public void LoadContent(ContentManager content, GraphicsDeviceManager graphics)
        {
            // Create a new SpriteBatch, which can be used to draw textures.

            // TODO: use this.Content to load your game content here

            backgroundTexture = content.Load<Texture2D>("map");
            backgroundVector = new Vector2(0, 0);

            playerTexture = content.Load<Texture2D>("hero");
            playerVector = new Vector2(400, 400);
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            #region Controls
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Down))
            {

            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Up))
            {

            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Left))
            {

            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right))
            {

            }
            #endregion
            // TODO: Add your update code here

            #region Controls
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Down))
            {

            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Up))
            {

            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Left))
            {

            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right))
            {

            }
            #endregion
            // TODO: Add your update code here

            base.Update(gameTime);
        }


        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();

            spriteBatch.Draw(backgroundTexture, backgroundVector, Color.White);

            float scale = .9f; //50% smaller
            spriteBatch.Draw(playerTexture, playerVector, new Rectangle(0, 0, 30, 60), Color.White, 0f, playerVector, scale, SpriteEffects.None, 0f);


            spriteBatch.End();

            //base.Draw(gameTime);
        }
    }
}
