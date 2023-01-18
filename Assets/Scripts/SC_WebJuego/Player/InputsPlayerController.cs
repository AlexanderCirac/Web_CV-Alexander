using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace WebGame.Game.Inputs
{
    using AlexanderCA.Tools;
    public class InputsPlayerController : MonoBehaviour
    {

        #region Attributes
        //control imputs
        internal delegate void MydelegateMovement(Vector3 _moveInput3D);
        internal MydelegateMovement _delegateInputsMovement;        
        
        internal delegate void MydelegateRotate(Vector3 _moveInput3D);
        internal MydelegateRotate _delegateInputsRotate;

        internal delegate void MydelegateJump();
        internal MydelegateJump _delegateInputsJump;
        #endregion

        #region UnityCalls       
        void Update()
        {
            ToMovementController(_delegateInputsMovement);
            ToRotateController(_delegateInputsRotate);
            ToJumpController(_delegateInputsJump);
            
        }
        #endregion

        #region privats customs methods
        void ToJumpController(MydelegateJump _myDelegateJump)
        {
            if ( Input.GetKeyDown(KeyCode.Space) )
            {
                _myDelegateJump?.Invoke();
            }
        }

        void ToMovementController(MydelegateMovement _mydelegateMovement)
        {
            if ( Input.GetAxis("Vertical") != 0 || Input.GetAxisRaw("Vertical") != 0)
            {
                _mydelegateMovement?.Invoke(ToolsAlex.GetMoveNormal3D());
            }
        }

        void ToRotateController(MydelegateRotate _delegateInputsRotate)
        {
            if( Mathf.Abs( Input.GetAxis("Mouse X") ) > 0 || Mathf.Abs(Input.GetAxis("Mouse Y")) > 0 )
            {
                _delegateInputsRotate?.Invoke(ToolsAlex.GetRotateNormal3D());
            }
           
        }
        #endregion
    }
}
