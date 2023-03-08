using UnityEngine;
using Zenject;

// Aqui indicaremos que el modulo de control sera mediante el uso de raton y teclado
namespace WebGame.Game.Inputs
{
    using AlexanderCA.Tools;
    using WebGame.Game.Templates;
    using WebGame.Game.ScriptableObject;
    public class InputsMouseKeyboard : InputsTemplates
    {
        #region Attributes
        [Inject]
        public SOPlayer _data;
        #endregion

        #region Abstract customs methods
        public override float GetVertical()
        {
            return ToolsAlex.GetMoveNormal3D(_data._keyLeft , _data._keyRight , _data._keyFrontOf , _data._keyBack).y;
        }
        public override float GetHorizontal()
        {
            return ToolsAlex.GetMoveNormal3D(_data._keyLeft , _data._keyRight , _data._keyFrontOf , _data._keyBack).x;
        }
        public override float GetRotationVertical()
        {
            return ToolsAlex.GetRotateMouse3D().y * _data._rotateSpeed;
        }
        public override float GetRotationHorizontal()
        {
            return ToolsAlex.GetRotateMouse3D().x * _data._rotateSpeed;
        }
        public override float GetJump()
        {
            return ToolsAlex.GetJumpDown(KeyCode.Space).z *_data._jumpsSpeed;
        }
        #endregion
    }
}
