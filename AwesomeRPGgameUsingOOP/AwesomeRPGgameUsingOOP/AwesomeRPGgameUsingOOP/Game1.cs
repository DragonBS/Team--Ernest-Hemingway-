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
using AwesomeRPGgameUsingOOP.Scenes;
using AwesomeRPGgameUsingOOP.Object_classes;
using AwesomeRPGgameUsingOOP.Object_classes.Items;

namespace AwesomeRPGgameUsingOOP
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        StartingScene startingScene;
        MainScene mainScene;
        GameOverScene gameoverScene;
        Hero hero; 
         
        internal int delayer;
        
        static public bool GameStarted;
        static public bool MainStarted;
        static public bool GameOverStarted;

  

        public Game1()
        {
            startingScene = new StartingScene(this);
            graphics = new GraphicsDeviceManager(this);
            mainScene = new MainScene(this);
            gameoverScene=new GameOverScene(this);
            hero = new Hero();
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            
            // Create a new SpriteBatch, which can be used to draw textures.
            startingScene.LoadContent(Content, graphics);
            spriteBatch = new SpriteBatch(GraphicsDevice);
            delayer = 0;
            // TODO: use this.Content to load your game content here
            GameStarted=true;
            MainStarted=false;
            GameOverStarted=false;
            ItemPics.LoadContent(Content);

            mainScene.LoadContent(Content, graphics);

            #region graphicset
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 800;

            //TEMPORARY CHANGED DUE TO TESTING PROBLEMS IN FULLS SCREEN
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();
            #endregion

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
                      
            if (Keyboard.GetState(PlayerIndex.One).IsKeyDown(Keys.Escape))
            {
                this.Exit();
            }
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            
            delayer++;
            if (delayer==7)
            {
                delayer = 0;
                if (GameStarted)
                {
                    startingScene.Update(gameTime);
                //    GameStarted = false;
                }
                if (MainStarted)
                {
                      mainScene.Update(gameTime);
                 //   MainStarted = false;
                }
                if (GameOverStarted)
                {
                //   gameoverScene.Update(gameTime);
                //    gameoverScene = false;
                }
                
            }

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            if (GameStarted)
            {
                startingScene.Draw(gameTime, spriteBatch);
                //    GameStarted = false;
            }
            if (MainStarted)
            {
                
                mainScene.Draw(gameTime,spriteBatch);
                //   MainStarted = false;
            }
            if (GameOverStarted)
            {
                //gameoverScene.Draw(gameTime, spriteBatch);
                //    gameoverScene = false;
            }
            
                       // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
