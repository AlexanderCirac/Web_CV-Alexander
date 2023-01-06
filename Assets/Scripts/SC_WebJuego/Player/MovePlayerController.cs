using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGame.Game.Inputs
{
    public class MovePlayerController : InputsController
    {
        #region Attributes
        public GameObject player;
        #endregion

        #region UnityCalls     
        void Awake()
        {
            delegateInputsMovement += MovePlayer;
        }        
        
        void OnDestroy()
        {
            delegateInputsMovement -= MovePlayer;
        }
        #endregion

        #region privats customs methods
        void MovePlayer(Vector3 _move)
        {
            float speedMove = 20 * Time.deltaTime;
            player.transform.Translate( Vector3.forward * _move.x * speedMove);

        }
        #endregion
    }
}
