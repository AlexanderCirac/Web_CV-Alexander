using UnityEngine;

namespace WebGame.Game.Mechanical
{
    using WebGame.Game;
    public class ObservableEvent : MonoBehaviour, IPlayerEventCollider
    {
        #region Attributes
        [SerializeField] private GameObject _elementObservable;
        #endregion


        #region private custom methods
        void IPlayerEventCollider.ToEnterEventCollider(GameObject _player)
        {
            _elementObservable.SetActive(true);
        }
        void IPlayerEventCollider.ToStayEventCollider()
        {
        }
        void IPlayerEventCollider.ToExitEventCollider()
        {
            _elementObservable.SetActive(false);
        }
        #endregion
    }
}