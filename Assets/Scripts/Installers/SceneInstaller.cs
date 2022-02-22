using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SceneInstaller : MonoInstaller
{
    public JollyGood.Systems.Item.ItemDataRepoScriptable itemDataRepo;

    public override void InstallBindings()
    {

        Container.Bind<JollyGood.Systems.Item.IItemDataRepo>().FromInstance(itemDataRepo).AsSingle();
            
    }
}
