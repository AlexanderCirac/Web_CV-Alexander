using UnityEngine;

namespace WebGame.Game.Inputs
{
    public class PlayerMovement : MonoBehaviour
    {
        #region Attributes
        [Header("Get Inputs Controller")]
        public   InputsController   _inputsController;
        private  Vector2                 _axisRot;
        #endregion

        #region UnityCalls     
        void Awake()
        {
            _inputsController._delegateInputsMovement += ToMove;
            _inputsController._delegateInputsRotate += ToRotate;
            _inputsController._delegateInputsJump += ToJump;
        }

        void OnDestroy()
        {
            _inputsController._delegateInputsMovement -= ToMove;
            _inputsController._delegateInputsRotate -= ToRotate;
            _inputsController._delegateInputsJump -= ToJump;
        }
        #endregion

        #region privats customs methods
        void ToMove(float _moveX , float _moveY)
        {
            float _moveSpeed = Input.GetKey(KeyCode.LeftShift) ? 10 * Time.deltaTime : 5 * Time.deltaTime;
            this.transform.Translate(Vector3.forward * _moveX * _moveSpeed);
            this.transform.Translate(Vector3.right * _moveY * _moveSpeed);
        }
        void ToRotate(float _moveX , float _moveY)
        {
            float _rotateSpeed = 180 * Time.deltaTime;
            _axisRot.x += _moveX * _rotateSpeed;
            _axisRot.y += _moveY * _rotateSpeed;
            float _clampX = Mathf.Clamp(-_axisRot.x , -40 , 20);
            transform.localRotation = Quaternion.Euler(_clampX , _axisRot.y , 0);
        }
        void ToJump()
        {
            float _jumpSpeed = 300 * Time.deltaTime;
            GetComponent<Rigidbody>().velocity = ( Vector3.up * _jumpSpeed );
        }
        #endregion
    }
}
