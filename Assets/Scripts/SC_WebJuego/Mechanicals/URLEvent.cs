using UnityEngine;

namespace WebGame.Game.Mechanical
{
    public class URLEvent : MonoBehaviour, IPlayerEventCollider
    {
        #region Attributes
        [SerializeField] private string _urlText;
        #endregion

        #region private custom methods
        void IPlayerEventCollider.ToEnterEventCollider(GameObject _player)
        {
            Application.OpenURL(_urlText);
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
