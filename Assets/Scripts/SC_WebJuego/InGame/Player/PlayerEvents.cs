using UnityEngine;

namespace WebGame.Game
{
    using WebCV.Tools.Interface;
    public class PlayerEvents : MonoBehaviour
    {
        #region UnityCalls
        private void OnTriggerStay(Collider other) => other?.GetComponent<IPlayerStayCollider>()?.ToStayEventCollider();

        private void OnTriggerEnter(Collider other) => other?.GetComponent<IPlayerEnterCollider>()?.ToEnterEventCollider(this.transform.parent.gameObject);

        private void OnTriggerExit(Collider other) => other?.GetComponent<IPlayerExitCollider>()?.ToExitEventCollider();

        #endregion
    }
}
