using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AwesomeRPGgameUsingOOP.Object_classes
{
    public class Hero: Character
    {
        public int FreeInventorySlots { get; set; }

        public void PickupItem(Item item)
        {
            if (this.FreeInventorySlots!=0)
            {
                this.FreeInventorySlots--;
                this.Items.Add(item);
            }
        }

    }
}
