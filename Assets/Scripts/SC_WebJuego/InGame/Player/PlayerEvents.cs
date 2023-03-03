using UnityEngine;

namespace WebGame.Game
{
    using WebCV.Tools.Interface;
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
