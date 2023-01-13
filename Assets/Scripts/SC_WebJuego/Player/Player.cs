using UnityEngine;

namespace WebGame.Game
{
public interface IEventCollider
{
    public void ToStayEventCollider();
    public void ToEnterEventCollider();
    public void ToExitEventCollider();
}
    public class Player : MonoBehaviour
    {

        #region UnityCalls
        private void OnTriggerStay(Collider other)
        {

            if ( other.TryGetComponent(out IEventCollider IeventCollider) )
                IeventCollider.ToStayEventCollider();
        }        
        private void OnTriggerEnter(Collider other)
        {

            if ( other.TryGetComponent(out IEventCollider IeventCollider) )
                IeventCollider.ToEnterEventCollider();
        }
        private void OnTriggerExit(Collider other)
        {

            if ( other.TryGetComponent(out IEventCollider IeventCollider) )
                IeventCollider.ToExitEventCollider();
        }
        #endregion 

    }
}
