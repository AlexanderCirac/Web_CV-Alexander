using Zenject;
using WebGame.Game.ScriptableObject;

public class DataSoInstaller : MonoInstaller
{
    public SOPlayer _dataPlayer;
    public override void InstallBindings()
    {
        Container.BindInstance(_dataPlayer).AsSingle();
    }
}
