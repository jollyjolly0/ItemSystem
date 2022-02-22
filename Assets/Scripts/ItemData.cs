using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace JollyGood.Systems.Item
{
    [System.Serializable]
    public class ItemData
    {
        public string itemName;
        public Sprite itemIcon;

        public string description;

        public ItemData(string itemName, Sprite icon)
        {
            this.itemName = itemName;
            this.itemIcon = icon;
        }
    }

}
