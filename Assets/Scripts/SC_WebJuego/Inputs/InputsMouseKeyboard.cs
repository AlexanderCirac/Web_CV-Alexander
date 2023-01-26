using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Aqui indicaremos que el modulo de control sera mediante el uso de raton y teclado
namespace WebGame.Game.Inputs
{
    using AlexanderCA.Tools;
    public class InputsMouseKeyboard : InputsTemplates
    {
        [Header("Set Keys to inputs")]
        [Range(1,100)]
        [SerializeField] private float   _senitivy;
        [SerializeField] private KeyCode _keyLeft;
        [SerializeField] private KeyCode _keyRight;
        [SerializeField] private KeyCode _keyFrontOf;
        [SerializeField] private KeyCode _keyBack;
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
            return ToolsAlex.GetRotateMouse3D().y* _senitivy;
        }       
        public override float GetRotationHorizontal()
        {
            return ToolsAlex.GetRotateMouse3D().x* _senitivy;
        }
        public override float GetJump()
        {           
            return ToolsAlex.GetJumpDown(KeyCode.Space).z;
        }
    }
}
