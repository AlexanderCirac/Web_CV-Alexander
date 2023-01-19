using UnityEngine;

namespace WebGame.Game
{
    public interface IPlayerStayCollider
    {
        public void ToStayEventCollider();
    }
    public interface IPlayerEnterCollider
    {
        public void ToEnterEventCollider(GameObject _player);
    }
    public interface IPlayerExitCollider
    {
        public void ToExitEventCollider();
    }

    public class PlayerEvents : MonoBehaviour
    {
        #region UnityCalls
        private void OnTriggerStay(Collider other)
        {
            if ( other.TryGetComponent(out IPlayerStayCollider IeventCollider) )
            {
                IeventCollider.ToStayEventCollider();
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if ( other.TryGetComponent(out IPlayerEnterCollider IeventCollider) )
            {
                IeventCollider.ToEnterEventCollider(this.transform.parent.gameObject);
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if ( other.TryGetComponent(out IPlayerExitCollider IeventCollider) )
            {
                IeventCollider.ToExitEventCollider();
            }
        }
        #endregion 
    }
}
