using UnityEngine;

namespace WebGame.Game
{
    public interface IPlayerEventCollider
    {
        public void ToStayEventCollider();
        public void ToEnterEventCollider(GameObject _player);
        public void ToExitEventCollider();
    }
    public class Player : MonoBehaviour
    {

        #region UnityCalls
        private void OnTriggerStay(Collider other)
        {

            if ( other.TryGetComponent(out IPlayerEventCollider IeventCollider) )
            {
                IeventCollider.ToStayEventCollider();
            }
        }
        private void OnTriggerEnter(Collider other)
        {

            if ( other.TryGetComponent(out IPlayerEventCollider IeventCollider) )
            {
                IeventCollider.ToEnterEventCollider(this.transform.parent.gameObject);
            }
        }
        private void OnTriggerExit(Collider other)
        {

            if ( other.TryGetComponent(out IPlayerEventCollider IeventCollider) )
            {
                IeventCollider.ToExitEventCollider();
            }
        }
        #endregion 

    }
}
