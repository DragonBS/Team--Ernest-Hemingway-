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
        private const float scalePlayer = .9f;

        private Texture2D backgroundTexture;
        private Vector2 backgroundVector;

        private Texture2D playerTexture;
        private Vector2 playerVector;

        private ContentManager content;
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private GameTime gameTime;

        public ContentManager Content { get; set; }
        public GraphicsDeviceManager Graphics { get; set; }
        public GameTime Gametime { get; set; }
        public SpriteBatch SpriteBatch { get; set; }

        public MainScene(Game game, ContentManager content, GraphicsDeviceManager graphics,GameTime gameTime, SpriteBatch spriteBatch)
            : base(game)
        {
            this.Content = content;
            this.Graphics = graphics;
            this.SpriteBatch = spriteBatch;
            this.Gametime = gameTime;
            // TODO: Construct any child components here
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            this.LoadContent(this.Content, this.Graphics);
            this.Draw(this.Gametime, this.SpriteBatch);
            base.Initialize();
        }

        public void LoadContent(ContentManager content, GraphicsDeviceManager graphics)
        {
            // TODO: use this.Content to load your game content here

            backgroundTexture = Content.Load<Texture2D>("map");
            backgroundVector = new Vector2(0, 0);

            //playerTexture = Content.Load<Texture2D>("hero");
            //playerVector = new Vector2(400, 400);
        }




        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {

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
            // TODO: Add your drawing code here

            //GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(backgroundTexture, backgroundVector, Color.White);

            //spriteBatch.Draw(playerTexture, playerVector, new Rectangle(0, 0, 30, 60), Color.White, 0f, playerVector, scalePlayer, SpriteEffects.None, 0f);

            spriteBatch.End();

            //base.Draw(gameTime);
        }
    }




}
