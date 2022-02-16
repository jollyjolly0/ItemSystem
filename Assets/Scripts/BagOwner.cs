using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Zenject;


namespace JollyGood.Systems.Item
{

public class BagOwner : MonoBehaviour
{
    JollyGood.Systems.Item.ItemContainer bag;

    JollyGood.Systems.Item.ItemSource source;

        ContainerRenderer renderer;

        [Inject]    
        void Construct(JollyGood.Systems.Item.ItemSource src)
        {
            source = src;
        }


        private void Awake()
        {

            renderer = GetComponentInChildren<ContainerRenderer>();


        }
            void Start() { 

           bag = new ItemContainer();


            Transaction trade = new Transaction(bag, source, 
                new List<Item>() { new Item(1) }, 
                new List<Item>());

            trade.ApplyTransaction();
           Debug.Log("awd");


            renderer.UpdateDisplay(new Item(1));
        }

        


    }
    
    

}
