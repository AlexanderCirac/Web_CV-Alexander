using UnityEngine;

namespace WebGame.Game.Mechanical
{
    using WebGame.Game;
    public class ObservableEvent : MonoBehaviour, IEventCollider
    {
        #region Attributes
        [SerializeField] private GameObject _elementObservable;
        #endregion


        #region private custom methods
        void IEventCollider.ToEnterEventCollider(GameObject _player)
        {
            _elementObservable.SetActive(true);
        }
        void IEventCollider.ToStayEventCollider()
        {
        }
        void IEventCollider.ToExitEventCollider()
        {
            _elementObservable.SetActive(false);
        }
        #endregion
    }
}