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
using AwesomeRPGgameUsingOOP.Object_classes.Items;
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
        private Texture2D arrowTexture;
        private Vector2 arrowVector;
        private float delta;

        public SkillsScene(Game game, Hero hero)
            : base(game)
        {
            this.hero = hero;
            delta = 0;
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
            arrowTexture = content.Load<Texture2D>("arrow1");
            arrowVector = new Vector2(480, 340);
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

        private void GetEquipedItems(out string weapon, out string helmet, out string body, out string gloves, out string boots)
        {
            var armoursList = hero.Items.FindAll((x) => x is Armour);
            var helmets = armoursList.FindAll(x => x is Helm);
            var selectedHelmet = helmets.FindAll(x => x.IsEquipped);

            var bodiesList = armoursList.FindAll(x => x is Body);
            var selectedBody = helmets.FindAll(x => x.IsEquipped);

            var glovesList = armoursList.FindAll(x => x is Gloves);
            var selectedGloves = glovesList.FindAll(x => x.IsEquipped);

            var bootsList = armoursList.FindAll(x => x is Boots);
            var selectedBoots = armoursList.FindAll(x => x.IsEquipped);

            var weaponsList = hero.Items.FindAll(x => x is Weapon);
            var selectedWeapon = weaponsList.FindAll(x => x.IsEquipped);

            string nan = "N/A";
            weapon = nan;
            helmet = nan;
            body = nan;
            gloves = nan;
            boots = nan;

            if (selectedHelmet.Count != 0)
            {
                helmet = string.Format("+{0}", selectedHelmet[0].Armour);
            }
            if (selectedBody.Count != 0)
            {
                body = string.Format("+{0}", selectedBody[0].Armour);
            }
            if (selectedGloves.Count != 0) 
            {
                gloves = string.Format("+{0}", selectedGloves[0].Armour);
            }
            if (selectedBoots.Count != 0) 
            {
                boots = string.Format("+{0}", selectedBoots[0].Armour);
            }
            if (selectedWeapon.Count != 0)
            {
                weapon = string.Format("+{0}", selectedWeapon[0].Damage);
            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(backGroundTexture, BackgroundVector, Color.White);
            spriteBatch.Draw(arrowTexture, new Vector2(arrowVector.X+(float)(Math.Sin(delta))*6, arrowVector.Y), Color.White);
            delta += 0.1f;
            if (delta > Math.PI*10)
            {
                delta = 0;
            }
            int numberOfPixels = 20;
            string name= "NAME";
            
            spriteBatch.DrawString(font, hero.Level.ToString(), new Vector2(380 - hero.Level.ToString().Length / (float)2 * numberOfPixels, 75), Color.Black, 0, new Vector2(0, 0), 2, new SpriteEffects(), 1);
            spriteBatch.DrawString(font, hero.Health.ToString(), new Vector2(380 - hero.Health.ToString().Length /(float)2 * numberOfPixels, 185), Color.Black, 0, new Vector2(0, 0), 2, new SpriteEffects(), 1);
            spriteBatch.DrawString(font, hero.Armour.ToString(), new Vector2(380 - hero.Armour.ToString().Length / (float)2 * numberOfPixels, 300), Color.Black, 0, new Vector2(0, 0), 2, new SpriteEffects(), 1);
            spriteBatch.DrawString(font, hero.Damage.ToString(), new Vector2(380 - hero.Damage.ToString().Length / (float)2 * numberOfPixels, 420), Color.Black, 0, new Vector2(0, 0), 2, new SpriteEffects(), 1);

            spriteBatch.DrawString(font, name, new Vector2(180 - name.Length /(float)4 * numberOfPixels, 240), Color.Black, 0, new Vector2(0, 0), 1, new SpriteEffects(), 1);
            spriteBatch.DrawString(font, hero.Experience.ToString(), new Vector2(180 - hero.Level.ToString().Length/ (float)4 * numberOfPixels, 310), Color.Black, 0,new Vector2(0,0),1, new SpriteEffects(), 1);

            string weapon;
            string helmet;
            string body;
            string gloves;
            string boots;

            GetEquipedItems(out weapon, out helmet, out body, out gloves, out boots);

            spriteBatch.DrawString(font, string.Format("Helmet: {0}", helmet), new Vector2(70, 395), Color.Black, 0, new Vector2(0, 0), 0.8f, new SpriteEffects(), 1);
            spriteBatch.DrawString(font, string.Format("Body: {0}", body), new Vector2(70, 415), Color.Black, 0, new Vector2(0, 0), 0.8f, new SpriteEffects(), 1);
            spriteBatch.DrawString(font, string.Format("Gloves: {0}", gloves), new Vector2(70, 435), Color.Black, 0, new Vector2(0, 0), 0.8f, new SpriteEffects(), 1);
            spriteBatch.DrawString(font, string.Format("Boots: {0}", boots), new Vector2(70, 455), Color.Black, 0, new Vector2(0, 0), 0.8f, new SpriteEffects(), 1);
            spriteBatch.DrawString(font, string.Format("Weapon: {0}", weapon), new Vector2(70, 475), Color.Black, 0, new Vector2(0, 0), 0.8f, new SpriteEffects(), 1);

            



            spriteBatch.End();
        }
    }
}
