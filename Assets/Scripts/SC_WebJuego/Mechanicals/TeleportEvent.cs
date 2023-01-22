using UnityEngine;

namespace WebGame.Game.Mechanical
{
    using WebCV.Tools.Interface;
    public class TeleportEvent : MonoBehaviour, IPlayerEnterCollider
    {
        #region Attributes
        [SerializeField] private GameObject _destiniTeleport;
        #endregion

        #region private custom methods
        void IPlayerEnterCollider.ToEnterEventCollider(GameObject _player)
        {
            _player.transform.position = _destiniTeleport.transform.position;
        }
        #endregion
    }
}
