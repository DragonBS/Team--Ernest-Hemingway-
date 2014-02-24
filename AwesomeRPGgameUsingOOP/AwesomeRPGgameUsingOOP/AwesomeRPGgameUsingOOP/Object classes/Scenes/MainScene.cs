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
    public class MainScene : Microsoft.Xna.Framework.DrawableGameComponent
    {
        private const float scalePlayer = .9f;

        private Texture2D backgroundTexture;
        private Vector2 backgroundVector;

        private Texture2D playerTexture;
        private Rectangle playerRectangle;
        private Vector2 playerVector;
        private Vector2 playerPosition;


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
            base.Initialize();
        }

        public void LoadContent(ContentManager content, GraphicsDeviceManager graphics)
        {
            // TODO: use this.Content to load your game content here

            backgroundTexture = content.Load<Texture2D>("map");
            backgroundVector = new Vector2(0, 0);

            playerTexture = content.Load<Texture2D>("hero");
            playerVector = new Vector2(0, 0);
            playerRectangle = new Rectangle(0, 0, 30, 60);
            playerPosition = new Vector2(380, 480);
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
                this.AnimateHero(gameTime, "down", playerPosition, playerRectangle);
            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Up))
            {
                this.AnimateHero(gameTime, "up", playerPosition, playerRectangle);
            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Left))
            {
                this.AnimateHero(gameTime, "left", playerPosition, playerRectangle);
            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right))
            {
                this.AnimateHero(gameTime, "right", playerPosition, playerRectangle);
            }
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Space))
            {
                this.HeroAttack(gameTime);
           }
            #endregion

            base.Update(gameTime);
        }


        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            // TODO: Add your drawing code here

            //GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(backgroundTexture, backgroundVector, Color.White);

            spriteBatch.Draw(playerTexture, playerPosition, playerRectangle, Color.White, 0f, playerVector, scalePlayer, SpriteEffects.None, 0f);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        //TO DO fix return state whe attacking
        protected void HeroAttack(GameTime gameTime)
        {
           int timer = 10;
           double elapsed = gameTime.ElapsedGameTime.TotalMilliseconds;
           timer -= (int)elapsed;
            this.playerRectangle.Y += 120;

            if (timer <= 0)
            {
                this.playerRectangle.Y -= 120;
                timer = 10;
            }
        }


        //TO DO
        protected void AnimateHero(GameTime gameTime, string direction, Vector2 playerPostion, Rectangle playerRectangle)
        {
            if (direction=="up")
            {
                this.playerPosition.Y -= 5;
                this.playerRectangle.Y = 128;
            }
            else if (direction == "down")
            {
                this.playerPosition.Y += 5;
                this.playerRectangle.Y = 0;
            }
            else if (direction == "left")
            {
                this.playerPosition.X -= 5;
                this.playerRectangle.Y = 64;
            }
            else if (direction == "right")
            {
                this.playerPosition.X += 5;
                this.playerRectangle.Y = 192;
            }
        }

        //TO DO check if current position is available
        protected void CheckHeroPosition(Vector2 playerPostion)
        {

        }
    }




}
