using UnityEngine;
using UniRx;
using WebCV.Tools.Interface;

namespace WebGame.Game
{
    using UniRx.Triggers;
    public class PlayerEvents : MonoBehaviour
    {
        #region UnityCalls

        private void Start()
        {
            //this.OnTriggerEnterAsObservable()
            //    .Where(other => other.TryGetComponent(out IPlayerStayCollider IeventCollider))
            //    .Subscribe(_ => IeventCollider.)
            //    .AddTo(this);
        }
        //private void OnTriggerStay(Collider other)
        //{
        //    if ( other.TryGetComponent(out IPlayerStayCollider IeventCollider) )
        //    {
        //        IeventCollider.ToStayEventCollider();
        //    }
        //}
        //private void OnTriggerEnter(Collider other)
        //{
        //    if ( other.TryGetComponent(out IPlayerEnterCollider IeventCollider) )
        //    {
        //        IeventCollider.ToEnterEventCollider(this.transform.parent.gameObject);
        //    }
        //}
        //private void OnTriggerExit(Collider other)
        //{
        //    if ( other.TryGetComponent(out IPlayerExitCollider IeventCollider) )
        //    {
        //        IeventCollider.ToExitEventCollider();
        //    }
        //}
        #endregion 
    }
}
