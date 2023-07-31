using Zenject;
using System;
using UnityEngine;

namespace WebGame.Game
{
    using AlexanderCA.Tools;
    using WebGame.Game.ScriptableObject;
    using WebCV.Tools.Interface;

    public class InputsPlayer : IInputs
    {
        #region Attributes
        [Inject]
        public SOPlayer _data;
        #endregion

        #region Abstract customs methods
        public float GetVertical()
        {
            return ToolsAlex.GetMoveNormal3D(_data._keyLeft , _data._keyRight , _data._keyFrontOf , _data._keyBack).y;
        }
        public float GetHorizontal()
        {
            return ToolsAlex.GetMoveNormal3D(_data._keyLeft , _data._keyRight , _data._keyFrontOf , _data._keyBack).x;
        }
        public float GetRotationVertical()
        {
            return ToolsAlex.GetRotateMouse3D().y * _data._rotateSpeed;
        }
        public float GetRotationHorizontal()
        {
            return ToolsAlex.GetRotateMouse3D().x * _data._rotateSpeed;
        }
        public float GetJump()
        {
            return ToolsAlex.GetJumpDown(KeyCode.Space).z * _data._jumpsSpeed;
        }
        #endregion
    }
}
