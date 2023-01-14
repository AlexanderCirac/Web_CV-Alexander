using UnityEngine;

namespace WebGame.Game.Mechanical
{
    using WebGame.Game;
    public class PushEvent : MonoBehaviour, IEventCollider
    {

        #region Attributes
        [SerializeField] private GameObject _elementMove;
        private Vector3 _initPose;
        #endregion

        #region unitycalls
        void Awake()
        {
            _initPose = _elementMove.transform.position;
        }
        #endregion
        #region private custom methods

        void IEventCollider.ToEnterEventCollider(GameObject _player)
        {
        }
        void IEventCollider.ToStayEventCollider()
        {
            _elementMove.transform.position = new Vector3(_initPose.x -(Mathf.PingPong(Time.time *1* Time.deltaTime, 5)),_elementMove.transform.position.y,_elementMove.transform.position.z);
        }


        void IEventCollider.ToExitEventCollider()
        {
            _elementMove.transform.position = _initPose;
        }
        #endregion
    }
}

