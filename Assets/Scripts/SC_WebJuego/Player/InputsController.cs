using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace WebGame.Game.Inputs
{
    using AlexanderCA.Tools;
    public class InputsController : MonoBehaviour
    {

        #region Attributes
        //control imputs
        internal delegate void MydelegateMovement(Vector3 _moveInput3D);
        internal MydelegateMovement delegateInputsMovement;

        internal delegate void MydelegateJump();
        internal MydelegateJump delegateInputsJump;
        #endregion

        #region UnityCalls       
        void Start()
        {
            var uniRXUpdate = Observable.EveryUpdate();
            uniRXUpdate.Where(_ => Input.GetAxis("Horizontal") != 0 || Input.GetAxisRaw("Horizontal") != 0);
            uniRXUpdate.Subscribe(_ => ToMovementController(delegateInputsMovement));
            uniRXUpdate.Where(_ => Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Joystick1Button0));
            uniRXUpdate.Subscribe(_ => ToJumpController(delegateInputsJump));
        }
        #endregion

        #region privats customs methods
        void ToJumpController(MydelegateJump _myDelegateJump)
        {
            if ( Input.GetKeyDown(KeyCode.Space) )
                _myDelegateJump?.Invoke();
        }

        void ToMovementController(MydelegateMovement _mydelegateMovement)
        {
            if ( Input.GetAxis("Horizontal") != 0 || Input.GetAxisRaw("Horizontal") != 0 )
                _mydelegateMovement?.Invoke(ToolsAlex.GetMoveNormal3D());
        }
        #endregion
    }
}
