using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using WebGame.Game.ScriptableObject;

public class PlayerSOInstaller : MonoInstaller
{
    public SOPlayer myScriptableObject;

    public override void InstallBindings()
    {
        Container.BindInstance(myScriptableObject).AsSingle();
    }
}
