using System.Collections.Generic;

namespace JollyGood.Systems.Item
{

    public enum WriteItemResultCode
    {
        OK,
        MissingItems,
    }

    public interface IReadableItemContainer
    {
        bool ContainsItem(Item item);
        bool ContainsItems(IReadOnlyList<Item> item);
    };

    public interface IWriteableItemContainer
    {
        WriteItemResultCode AddItem(Item item);
        WriteItemResultCode RemoveItem(Item item);
        WriteItemResultCode AddItems(IReadOnlyList<Item> item);
        WriteItemResultCode RemoveItems(IReadOnlyList<Item> item);
    };

    public interface IReadWriteableItemContainer : IReadableItemContainer , IWriteableItemContainer
    {
    }

    public interface IItemTransactioner
    {

    };
}