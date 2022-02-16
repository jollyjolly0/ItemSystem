using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JollyGood.Systems.Item
{

    public enum TransactionResultCode
    {
        success,
        containersMissingItems,
    }

    public class Transaction
    {
        private IReadWriteableItemContainer container1;
        private IReadWriteableItemContainer container2;

        private List<Item> to2;
        private List<Item> to1;

        public Transaction(IReadWriteableItemContainer container1, IReadWriteableItemContainer container2
            , List<Item> to2, List<Item> to1)
        {
            this.container1 = container1;
            this.container2 = container2;
            this.to2 = to2;
            this.to1 = to1;
        }


        public TransactionResultCode ApplyTransaction()
        {
            if (!container1.ContainsItems(to2)) { return TransactionResultCode.containersMissingItems; }
            if (!container2.ContainsItems(to1)) { return TransactionResultCode.containersMissingItems; }

            container1.RemoveItems(to2);
            container2.RemoveItems(to1);

            container1.AddItems(to1);
            container2.AddItems(to2);

            return TransactionResultCode.success;
            
        }




    }
}
