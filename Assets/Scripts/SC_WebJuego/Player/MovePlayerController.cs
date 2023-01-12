using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WebGame.Game.Inputs
{
    public class MovePlayerController : InputsPlayerController
    {
        #region Attributes
        public GameObject _player;
        #endregion

        #region UnityCalls     
        void Awake()
        {

            _delegateInputsMovement += MovePlayer;
            _delegateInputsRotate   += RotatePlayer;
            _delegateInputsJump     += JumpPlayer;
        }

        void OnDestroy()
        {
            _delegateInputsMovement -= MovePlayer;
            _delegateInputsRotate   -= RotatePlayer;
            _delegateInputsJump     -= JumpPlayer;
        }
        #endregion

        #region privats customs methods
        void MovePlayer(Vector3 _move)
        {
            float _moveSpeed = Input.GetKey(KeyCode.LeftShift) ? 10 * Time.deltaTime : 5 * Time.deltaTime;
            _player.transform.Translate(Vector3.forward * _move.x * _moveSpeed);
        }
        void RotatePlayer(Vector3 _move)
        {
            float _rotateSpeed = 180 * Time.deltaTime;
            _player.transform.Rotate(Vector3.up * _move.y * _rotateSpeed , Space.Self);
        }

        void JumpPlayer()
        {
            float _jumpSpeed = 300 * Time.deltaTime;
            _player.GetComponent<Rigidbody>().velocity = (Vector3.up * _jumpSpeed);
        }
        #endregion
    }
}
