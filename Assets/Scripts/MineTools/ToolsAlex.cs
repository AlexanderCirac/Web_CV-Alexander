using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AlexanderCA.Tools
{
    public static class ToolsAlex
    {
        public static RectTransform GetRectTransform(this Transform t)
        {
            return t as RectTransform;
        }
        public static Vector2 GetMoveNormal2D()
        {
            Vector2 movementInput = Vector3.zero;

            if ( Input.GetKey(KeyCode.D) || Input.GetAxisRaw("Horizontal") > 0 )
            {
                movementInput.x = 1;
            }
            else if ( Input.GetKey(KeyCode.A) || Input.GetAxisRaw("Horizontal") < 0 )
            {
                movementInput.x = -1;
            }
            if ( Input.GetKey(KeyCode.W) || Input.GetAxisRaw("Vertical") > 0 )
            {
                movementInput.y = 1;
            }
            else if ( Input.GetKey(KeyCode.S) || Input.GetAxisRaw("Vertical") < 0 )
            {
                movementInput.y = -1;
            }
            return movementInput;
        }

        public static Vector2 GetMoveNormal2DSmooth(float _vlocity = 1)
        {
            Vector2 movementInput = Vector3.zero;

            if ( Input.GetAxis("Horizontal") != 0 )
            {
                movementInput.x = Input.GetAxis("Horizontal") * _vlocity;
            }
            if ( Input.GetAxisRaw("Horizontal") != 0 )
            {
                movementInput.x = Input.GetAxisRaw("Horizontal") * _vlocity;
            }
            if ( Input.GetAxis("Vertical") != 0 )
            {
                movementInput.y = Input.GetAxis("Vertical") * _vlocity;
            }
            if ( Input.GetAxisRaw("Vertical") != 0 )
            {
                movementInput.y = Input.GetAxisRaw("Vertical") * _vlocity;
            }
            return movementInput;
        }

        public static Vector3 GetMoveNormal3D()
        {
            Vector3 movementInput = Vector3.zero;

            if ( Input.GetKey(KeyCode.D) || Input.GetAxisRaw("Horizontal") > 0 )
            {
                movementInput.x = 1;
            }
            else if ( Input.GetKey(KeyCode.A) || Input.GetAxisRaw("Horizontal") < 0 )
            {
                movementInput.x = -1;
            }
            if ( Input.GetKey(KeyCode.W) || Input.GetAxisRaw("Vertical") > 0 )
            {
                movementInput.z = 1;
            }
            else if ( Input.GetKey(KeyCode.S) || Input.GetAxisRaw("Vertical") < 0 )
            {
                movementInput.z = -1;
            }

            if ( Input.GetAxis("Mouse X") > 0/* || Input.GetAxisRaw("Vertical") > 0*/ )
            {
                movementInput.y = 1;
            }
            else if ( Input.GetAxis("Mouse X") < 0/*|| Input.GetAxisRaw("Vertical") < 0*/ )
            {
                movementInput.y = -1;
            }
            return movementInput;
        }
    }
}
