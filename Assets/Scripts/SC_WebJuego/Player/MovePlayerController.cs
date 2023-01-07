using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WebGame.Game.Inputs
{
    public class MovePlayerController : MonoBehaviour
    {
        #region Attributes
        public GameObject player;
        InputsController _inputsController;
        #endregion

        #region UnityCalls     
        void Awake()
        {
            TryGetComponent(out _inputsController);
            _inputsController._delegateInputsMovement += MovePlayer;
            _inputsController._delegateInputsRotate += RotatePlayer;
        }

        void OnDestroy()
        {
            _inputsController._delegateInputsMovement -= MovePlayer;
            _inputsController._delegateInputsRotate -= RotatePlayer;
        }
        #endregion

        #region privats customs methods
        void MovePlayer(Vector3 _move)
        {
            float moveSpeed = 5 * Time.deltaTime;
            player.transform.Translate(Vector3.forward * _move.x * moveSpeed);
        }

        void RotatePlayer(Vector3 _move)
        {
            float rotateSpeed = 180 * Time.deltaTime;
            player.transform.Rotate(Vector3.up * _move.y * rotateSpeed , Space.Self);
        }
        #endregion
    }
}
