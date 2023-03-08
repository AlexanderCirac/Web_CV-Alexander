using UnityEngine;
using Zenject;
using WebGame.Game.ScriptableObject;

[CreateAssetMenu(fileName = "SOPlayerInstaller", menuName = "Installers/SOPlayerInstaller")]
public class SOPlayerInstaller : ScriptableObjectInstaller<SOPlayerInstaller>
{
    private PlayerSOZenject myScriptableObject;

    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<PlayerSOZenject>().AsSingle();
    }
}