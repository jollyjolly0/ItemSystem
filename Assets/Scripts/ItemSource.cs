using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JollyGood.Systems.Item
{
    public class ItemSource : IItemTransactioner, IReadWriteableItemContainer
    {



        public WriteItemResultCode AddItem(Item item)
        {
            return WriteItemResultCode.OK;
        }

        public WriteItemResultCode AddItems(IReadOnlyList<Item> item)
        {
            return WriteItemResultCode.OK;
        }

        public bool ContainsItem(Item item)
        {
            return true;
        }

        public bool ContainsItems(List<Item> item)
        {
            return true;
        }

        public bool ContainsItems(IReadOnlyList<Item> item)
        {
            return true;
        }

        public WriteItemResultCode RemoveItem(Item item)
        {
            return WriteItemResultCode.OK;
        }

        public WriteItemResultCode RemoveItems(IReadOnlyList<Item> item)
        {
            return WriteItemResultCode.OK;
        }
    }
}
