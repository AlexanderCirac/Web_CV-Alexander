using UnityEngine;

public interface IEventCollider
{
    void ToEnterEventCollider();
    void ToExitEventCollider();
}
namespace WebGame.Game
{
    public class Player : MonoBehaviour
    {

        #region UnityCalls
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
