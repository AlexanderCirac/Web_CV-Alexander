using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Aqui indicaremos que el modulo de control sera mediante el uso de raton y teclado
namespace WebGame.Game.Inputs
{
    using AlexanderCA.Tools;
    public class InputsMouseKeyboard : InputsBehaviour
    {
        [Range(1,100)]
        public float senitivy;
        public KeyCode _keyLeft;
        public KeyCode _keyRight;
        public KeyCode _keyFrontOf;
        public KeyCode _keyBack;
        public override float GetVertical()
        {
            return ToolsAlex.GetMoveNormal3D( _keyLeft, _keyRight , _keyFrontOf , _keyBack).y;
        }
        public override float GetHorizontal()
        {
            return ToolsAlex.GetMoveNormal3D( _keyLeft, _keyRight , _keyFrontOf , _keyBack).x;
        }
        public override float GetRotationVertical()
        {
            return ToolsAlex.GetRotateMouse3D().y* senitivy;
        }       
        public override float GetRotationHorizontal()
        {
            return ToolsAlex.GetRotateMouse3D().x* senitivy;
        }

        public override float GetJump()
        {           
            return ToolsAlex.GetJumpDown(KeyCode.Space).z;
        }
    }
}
