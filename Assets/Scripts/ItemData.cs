using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JollyGood.Systems.Item
{
    public class ItemData
    {
        public string itemName;
        public Sprite itemIcon;

        public ItemData(string itemName, Sprite icon)
        {
            this.itemName = itemName;
            this.itemIcon = icon;
        }
    }

}
