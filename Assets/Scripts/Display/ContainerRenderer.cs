using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace JollyGood.Systems.Item
{
    public class ContainerRenderer : MonoBehaviour
    {
        Image imageComp;
        IItemDataRepo dataRepo;

        void Awake()
        {
            imageComp = GetComponentInChildren<Image>();
        }

        [Inject]
        void Construct(IItemDataRepo repo)
        {
            dataRepo = repo;
        }

        public void UpdateDisplay(Item item)
        {
            ItemData itemData = dataRepo.GetItemData(item);

            imageComp.sprite = itemData.itemIcon;
            Debug.Log("setting slot to " + itemData.itemName);
        }
    }
}