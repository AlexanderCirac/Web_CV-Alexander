using UnityEngine;
using WebCV.Tools.Interface;
using WebGame.Game;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IInputs>().WithId("Player").To<InputsPlayer>().AsSingle();
    }
}