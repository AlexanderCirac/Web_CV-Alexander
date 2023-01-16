using UnityEngine;

namespace WebGame.Game.Mechanical
{
    public class URLEvent : MonoBehaviour, IEventCollider
    {
        #region Attributes
        [SerializeField] private string _urlText;
        #endregion

        #region private custom methods
        void IEventCollider.ToEnterEventCollider(GameObject _player)
        {
            Application.OpenURL(_urlText);
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
