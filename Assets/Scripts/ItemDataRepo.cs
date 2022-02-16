using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JollyGood.Systems.Item
{
    public interface IItemDataRepo
    {
        ItemData GetItemData(Item item);
    }

    public class ItemDataRepo : IItemDataRepo
    {

        ItemData IItemDataRepo.GetItemData(Item item)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ItemDataRepoMock : IItemDataRepo
    {

        ItemData IItemDataRepo.GetItemData(Item item)
        {
            if(item.typeID == 0)
            {
                return new ItemData("Bronze Dagger", Sprite.Create(Texture2D.whiteTexture, new Rect(0,0,1,1), Vector2.zero));
            }
            else if(item.typeID == 1) 
            {
                return new ItemData("Bronze Sword", Sprite.Create(Texture2D.blackTexture, new Rect(0, 0, 1, 1), Vector2.zero));
            }


            throw new System.Exception("Invalid Item ID");
        }
    }
}
