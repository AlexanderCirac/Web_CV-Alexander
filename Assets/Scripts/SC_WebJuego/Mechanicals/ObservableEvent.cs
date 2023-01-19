using UnityEngine;

namespace WebGame.Game.Mechanical
{
    using WebGame.Game;
    public class ObservableEvent : MonoBehaviour, IPlayerEnterCollider, IPlayerExitCollider
    {
        #region Attributes
        [SerializeField] private GameObject _elementObservable;
        #endregion


        #region private custom methods
        void IPlayerEnterCollider.ToEnterEventCollider(GameObject _player)
        {
            _elementObservable.SetActive(true);
        }
        
        void IPlayerExitCollider.ToExitEventCollider()
        {
            _elementObservable.SetActive(false);
        }
        #endregion
    }
}