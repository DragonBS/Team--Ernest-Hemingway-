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
using System.Threading;


namespace AwesomeRPGgameUsingOOP.Scenes
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class MainScene : Microsoft.Xna.Framework.DrawableGameComponent
    {
        private const float ScalePlayer = 1.1f;
        private const float PlayerSpeed = 10;

        private Texture2D backgroundTexture;
        private Vector2 backgroundVector;

        private Texture2D playerTexture;
        private Rectangle playerRectangle;
        private Vector2 playerVector;
        private Vector2 playerPosition;

        //animation
        private float TimePerFrame;
        private int Frame;
        private float TotalElapsed;
        private bool HeroStanding;
        private int frameCount;

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
            playerRectangle = new Rectangle(0, 0, 32, 50);
            playerPosition = new Vector2(380, 480);
        }

        public void UpdateFrame(GameTime gameTime, float elapsedTime)
        {
            if (HeroStanding)
            {
                Frame = 0;
            }
            else
            {
                TotalElapsed += elapsedTime;
                if (TotalElapsed > TimePerFrame)
                {
                    Frame++;
                    // Keep the Frame between 0 and the total frames, minus one.
                    Frame = Frame % 6;
                    TotalElapsed -= TimePerFrame;
                }
            }

            this.Update(gameTime);
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
                this.AnimateHero(gameTime, "attack", playerPosition, playerRectangle);
            }
            if (Keyboard.GetState(PlayerIndex.One).GetPressedKeys().Length == 0)
	        {
		        this.AnimateHero(gameTime, "standing", playerPosition, playerRectangle);
	        }
            #endregion

            base.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            Draw(gameTime, spriteBatch, Frame);
        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, int frame)
        {
            // TODO: Add your drawing code here

            //GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(backgroundTexture, backgroundVector, Color.White);


            int FrameWidth = playerTexture.Width / 6;
            Rectangle sourceRectangle = new Rectangle(FrameWidth * frame, playerRectangle.Y,
                FrameWidth, playerRectangle.Height);

            spriteBatch.Draw(playerTexture, playerPosition, sourceRectangle, Color.White, 0f, playerVector, ScalePlayer, SpriteEffects.None, 0f);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        //TO DO bug with heroStanding and attack 
        protected void AnimateHero(GameTime gameTime, string direction, Vector2 playerPostion, Rectangle playerRectangle)
        {
            if (this.CheckHeroPosition(playerPosition, direction) == false )
            {
                return;
            }
            HeroStanding = false;
            if (direction == "up")
            {
                this.playerPosition.Y -= PlayerSpeed;
                this.playerRectangle.Y = 96;
            }
            else if (direction == "down")
            {
                this.playerPosition.Y += PlayerSpeed;
                this.playerRectangle.Y = 0;
            }
            else if (direction == "left")
            {
                this.playerPosition.X -= PlayerSpeed;
                this.playerRectangle.Y = 48;
            }
            else if (direction == "right")
            {
                this.playerPosition.X += PlayerSpeed;
                this.playerRectangle.Y = 144;
            }
            else if (direction == "attack"&&playerRectangle.Y + 192 < 384)
            {
                this.playerPosition.X += PlayerSpeed;
                this.playerRectangle.Y += 192;
            }
            else if (direction == "standing")
            {
                this.playerRectangle.X = 0;
                HeroStanding = true;
            }
        }

        //TO DO check if current position is available
        protected bool CheckHeroPosition(Vector2 postion, string direction)
        {
            Rectangle field = new Rectangle(30,48,backgroundTexture.Width-60,backgroundTexture.Height-96);

            if(direction == "up")
            {
                postion.Y -= 5;
            }
            if (direction == "down")
            {
                postion.Y += 5;
            }
            if (direction == "right")
            {
                postion.X += 5;
            }
            if (direction == "up")
            {
                postion.X -= 5;
            }
            return field.Contains((int)postion.X, (int)postion.Y);
        }
    }
}
