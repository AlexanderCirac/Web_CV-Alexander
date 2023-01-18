using UnityEngine;

namespace WebGame.Game.Mechanical
{
    using WebGame.Game;
    public class TeleportEvent : MonoBehaviour, IPlayerEventCollider
    {
        #region Attributes
        [SerializeField] private GameObject _destiniTeleport;
        #endregion

        #region private custom methods
        void IPlayerEventCollider.ToEnterEventCollider(GameObject _player)
        {
            _player.transform.position = _destiniTeleport.transform.position;
        }
        void IPlayerEventCollider.ToStayEventCollider()
        {          
        }
        void IPlayerEventCollider.ToExitEventCollider()
        {          
        }
        #endregion
    }
}
