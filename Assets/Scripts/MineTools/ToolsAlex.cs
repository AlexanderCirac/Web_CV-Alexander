using UnityEngine;

namespace AlexanderCA.Tools
{
   
    public static class ToolsAlex   
    {
        public static RectTransform GetRectTransform(this Transform t)
        {
            return t as RectTransform;
        }        
        public static Vector3 GetMoveNormal3D(KeyCode _keyLeft , KeyCode _keyRight , KeyCode _keyFrontOf , KeyCode _keyBack)
        {
            Vector3 movementInput = Vector3.zero;

            if ( Input.GetKey(_keyFrontOf) )
            {
                movementInput.x = 1;
            }
            else if ( Input.GetKey(_keyBack) )
            {
                movementInput.x = -1;
            }
            if ( Input.GetKey(_keyRight) )
            {
                movementInput.y = 1;
            }
            else if ( Input.GetKey(_keyLeft) )
            {
                movementInput.y = -1;
            }
            return movementInput;
        }
        public static Vector3 GetJumpDown(KeyCode _inputJump)
        {
            Vector3 movementInput = Vector3.zero;

            if ( Input.GetKeyDown(_inputJump) )
            {
                movementInput.z = 1;
            }

            return movementInput;
        }
        public static Vector3 GetRotateMouse3D()
        {
            Vector3 movementInput = Vector3.zero;

            if ( Input.GetAxis("Mouse X") > 0 )
            {
                movementInput.y = 1;
            }
            else if ( Input.GetAxis("Mouse X") < 0 )
            {
                movementInput.y = -1;
            }
            if ( Input.GetAxis("Mouse Y") > 0 )
            {
                movementInput.x = 1;
            }
            else if ( Input.GetAxis("Mouse Y") < 0 )
            {
                movementInput.x = -1;
            }
            return movementInput;
        }
        public static bool GetBoolOverlapBox(LayerMask _maskGround , GameObject _whoCheckObject )
        {
            bool  _checkGround = false;

            _checkGround = ( Physics.OverlapBox(_whoCheckObject.transform.position, _whoCheckObject.transform.localScale , Quaternion.identity  , _maskGround) ) != null;   

            return _checkGround;
        }
    }
}
