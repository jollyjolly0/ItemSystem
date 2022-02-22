using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JollyGood.Systems.Item
{
    [CreateAssetMenu(fileName ="NewItemRepo",menuName ="ItemRepo",order = 10000)]
    public class ItemDataRepoScriptable : ScriptableObject, IItemDataRepo
    {
        [SerializeField] private ItemData[] data;



        public ItemData GetItemData(Item item)
        {
            int id = item.typeID;
            if(id < 0 || id > data.Length) { throw new System.Exception("INVALID item attempting to be got"); }
            return data[item.typeID];
        }

    }
}
