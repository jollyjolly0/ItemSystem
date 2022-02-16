using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class ProjectInstaller : MonoInstaller
{

    public override void InstallBindings()
    {
        Container.Bind<JollyGood.Systems.Item.IItemDataRepo>().To<JollyGood.Systems.Item.ItemDataRepoMock>().AsSingle();
        Container.Bind<JollyGood.Systems.Item.ItemSource>().FromNew().AsSingle();
    }
}
