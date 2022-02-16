using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JollyGood.Systems.Item
{

    public class ItemContainer : IReadWriteableItemContainer, IItemTransactioner
    {
        private List<Item> items;

        public ItemContainer()
        {
            items = new List<Item>();
        }

        public WriteItemResultCode AddItem(Item item)
        {
            items.Add(item);
            return WriteItemResultCode.OK;
        }

        public WriteItemResultCode AddItems(IReadOnlyList<Item> item)
        {
            items.AddRange(item);
            return WriteItemResultCode.OK;
        }

        public bool ContainsItem(Item item)
        {
            return items.Contains(item);
        }

        public bool ContainsItems(IReadOnlyList<Item> addItems)
        {
            foreach (var x in addItems)
            {
                if (!items.Contains(x)) { return false; }
            }
            return true;
        }

        public WriteItemResultCode RemoveItem(Item item)
        {
            bool missing = !items.Remove(item);

            if (missing) { return WriteItemResultCode.MissingItems; }
            return WriteItemResultCode.OK;
        }

        public WriteItemResultCode RemoveItems(IReadOnlyList<Item> removeItems)
        {
            bool missing = false;
            foreach (var x in removeItems)
            {
                missing |= !items.Remove(x);
            }
            if (missing) { return WriteItemResultCode.MissingItems; }
            return WriteItemResultCode.OK;
        }


        

    }

}
