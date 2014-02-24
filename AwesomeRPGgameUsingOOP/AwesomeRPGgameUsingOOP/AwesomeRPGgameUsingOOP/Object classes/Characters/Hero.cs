using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AwesomeRPGgameUsingOOP.Object_classes
{
    public class Hero: Character
    {
        static List<int> herolevels = new List<int>(); //list containing exp treshholds for the character levels;

        public Texture2D HeroTexture { get; set; }
        public Vector2 HeroVector { get; set; }

        public int FreeInventorySlots { get; set; }
        public int Level { get; set; }
        public int SkillPoints { get; set; }
        public int PowerPoints { get; set; }
        

        public Hero()
        {
            //var itemArray = new Item[16];
            Items = new List<Item>(16);
            
            herolevels.Clear();//adding the needed xp for next lvls
            herolevels.Add(40);
            herolevels.Add(95);
            herolevels.Add(160);
            herolevels.Add(250);

            this.IsAlive = true;
            this.FreeInventorySlots = 16;
            this.Experience = 0;
            this.Level = 1;
            this.Health = 100;
            this.Armour = 5;
            this.Damage = 5;
            this.SkillPoints = 0;
            this.PowerPoints = 0;
            this.Gold = 10;
        }



        public void PickupItem(Item item)
        {
            if (this.FreeInventorySlots!=0)
            {
                this.FreeInventorySlots--;
                this.Items.Add(item);
            }
        }

        public void XPgain(int value)
        {
            this.Experience = this.Experience + value;
            if (this.Experience>=herolevels[0])
            {
                this.Level++;
                this.SkillPoints++;
                this.PowerPoints = this.PowerPoints + 5;
                herolevels.RemoveAt(0);
            }
        }



    }
}
