using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WebGame.Game.Mechanical
{
    using WebGame.Game;
    public class TeleportEvent : MonoBehaviour, IEventCollider
    {
        #region Attributes
        [SerializeField] private GameObject _destiniTeleport;
        #endregion

        #region private custom methods
        void IEventCollider.ToEnterEventCollider(GameObject _player)
        {
            _player.transform.position = _destiniTeleport.transform.position;
        }
        void IEventCollider.ToStayEventCollider()
        {          
        }
        void IEventCollider.ToExitEventCollider()
        {          
        }
        #endregion
    }
}
