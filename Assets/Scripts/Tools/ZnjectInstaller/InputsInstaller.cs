using Zenject;
using WebGame.Game.ScriptableObject;

public class InputsInstaller : MonoInstaller
{
    public SOPlayer _dataPlayer;
    public override void InstallBindings()
    {
        //var _inputsTemplates = GetComponent<InputsTemplates>();
        Container.BindInstance(_dataPlayer).AsSingle();
    }
}
