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
    /// 
    public enum MenuOptions
    { 
        NewGameActive, HelpActive
    };

    public class StartingScene : Microsoft.Xna.Framework.GameComponent
    {
        private MenuOptions Choice { get; set; }
        private Texture2D backgroundTexture;
        private Vector2 backgroundVector;
        private Texture2D helpTexture;
        private Vector2 helpVector;
        private Texture2D startTexture;
        private Vector2 startVector;
        private Texture2D exitTexture;
        private Vector2 exitVector;
        private Texture2D arrowTexture;
        private Vector2 arrowVector;
        private int timeOfLastKeyPressing;
        

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
            this.Choice = MenuOptions.NewGameActive;
        }

        public void LoadContent(ContentManager content, GraphicsDeviceManager graphics)
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            
            // TODO: use this.Content to load your game content here

            backgroundTexture = content.Load<Texture2D>("backgroungArtwork");
            backgroundVector = new Vector2(0, 0);
            helpTexture = content.Load<Texture2D>("help2");
            helpVector = new Vector2(graphics.GraphicsDevice.Viewport.Width / 2 - helpTexture.Width / 2, graphics.GraphicsDevice.Viewport.Height / 2 - helpTexture.Height / 2 + 150);
            startTexture = content.Load<Texture2D>("newGame2");
            startVector = new Vector2(graphics.GraphicsDevice.Viewport.Width / 2 - startTexture.Width / 2, helpVector.Y - 75);
            exitTexture = content.Load<Texture2D>("exit1");
            exitVector = new Vector2(graphics.GraphicsDevice.Viewport.Width / 2 - exitTexture.Width / 2, helpVector.Y + 75);
            arrowTexture = content.Load<Texture2D>("arrow1");
            arrowVector = new Vector2((int)(graphics.GraphicsDevice.Viewport.Width / 2.6) - startTexture.Width / 2 , startVector.Y);                       
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
                
                if (this.Choice == MenuOptions.NewGameActive)
                {
                    this.Choice = MenuOptions.HelpActive;
                }
                else if (this.Choice == MenuOptions.HelpActive)
                {
                    this.Choice = MenuOptions.NewGameActive;
                }

            }
            
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Down))
            {
                if (this.Choice == MenuOptions.NewGameActive)
                {
                    this.Choice = MenuOptions.HelpActive;
                }
                else if (this.Choice == MenuOptions.HelpActive)
                {
                    this.Choice = MenuOptions.NewGameActive;
                }
            }
            
                        

            Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Left);
            Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Right);

            // play
            // help
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            spriteBatch.Begin();
            

            spriteBatch.Draw(backgroundTexture, backgroundVector, Color.White);
            spriteBatch.Draw(helpTexture, helpVector, Color.White);
            spriteBatch.Draw(startTexture, startVector, Color.White);
            spriteBatch.Draw(exitTexture, exitVector, Color.White);
            switch (Choice)
            {
                case MenuOptions.NewGameActive:
                    {
                        arrowVector.Y = startVector.Y;
                        spriteBatch.Draw(arrowTexture, arrowVector, Color.White);
                        break;

                    }
                case MenuOptions.HelpActive:
                    {
                        arrowVector.Y = helpVector.Y;
                        spriteBatch.Draw(arrowTexture, arrowVector, Color.White);
                        break;
                    }
                default:
                    {
                        spriteBatch.Draw(arrowTexture, arrowVector, Color.White);
                        break;
                    };

            };
            spriteBatch.End();

            //base.Draw(gameTime);
        }

    }
}
