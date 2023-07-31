using UnityEngine;
using WebCV.Tools.Interface;
using WebGame.Game;
using WebGame.Game.Templates;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<IInputs>().To<InputsPlayer>().AsSingle();
    }
}