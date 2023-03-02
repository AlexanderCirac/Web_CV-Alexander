using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using WebGame.Game.Templates;

public class InputsInstaller : MonoInstaller
{
    public override void InstallBindings()
    {

        var _inputsTemplates = GetComponent<InputsTemplates>();

        Container.BindInstance(_inputsTemplates).AsSingle();

    }
}
