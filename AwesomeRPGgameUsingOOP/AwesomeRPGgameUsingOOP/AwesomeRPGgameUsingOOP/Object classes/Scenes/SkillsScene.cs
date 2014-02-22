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
using AwesomeRPGgameUsingOOP.Object_classes;

namespace AwesomeRPGgameUsingOOP.Scenes
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class SkillsScene : Microsoft.Xna.Framework.GameComponent
    {
        private Texture2D backGroundTexture;
        private Vector2 BackgroundVector;
        private SpriteFont font;
        private Hero hero;

        public SkillsScene(Game game, Hero hero)
            : base(game)
        {
            this.hero = hero;
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

        public void LoadContent(ContentManager content)
        {
            //font = content.Load<SpriteFont>("SpriteFont1");
            font = content.Load<SpriteFont>("SpriteFont1");
            backGroundTexture = content.Load<Texture2D>("skills");
            BackgroundVector = new Vector2(0, 0);
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {

            // TODO: Add your update code here

            base.Update(gameTime);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(backGroundTexture, BackgroundVector, Color.White);
            int numberOfPixels = 20;
            
            spriteBatch.DrawString(font, hero.Level.ToString(), new Vector2(380 - hero.Level.ToString().Length / (float)2 * numberOfPixels, 70), Color.Black, 0, new Vector2(0, 0), 2, new SpriteEffects(), 1);
            spriteBatch.DrawString(font, hero.Health.ToString(), new Vector2(380 - hero.Health.ToString().Length /(float)2 * numberOfPixels, 185), Color.Black, 0, new Vector2(0, 0), 2, new SpriteEffects(), 1);

            spriteBatch.DrawString(font, hero.Armour.ToString(), new Vector2(380 - hero.Armour.ToString().Length / (float)2 * numberOfPixels, 300), Color.Black, 0, new Vector2(0, 0), 2, new SpriteEffects(), 1);
            spriteBatch.DrawString(font, hero.Damage.ToString(), new Vector2(380 - hero.Damage.ToString().Length / (float)2 * numberOfPixels, 420), Color.Black, 0, new Vector2(0, 0), 2, new SpriteEffects(), 1);
            
            spriteBatch.End();
        }
    }
}
