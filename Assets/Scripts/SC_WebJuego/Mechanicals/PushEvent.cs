using UnityEngine;

namespace WebGame.Game.Mechanical
{
    using WebGame.Game;
    public class PushEvent : MonoBehaviour, IPlayerExitCollider, IPlayerStayCollider
    {

        #region Attributes
        [SerializeField] private  GameObject  _elementMove;
                         private  Vector3     _initPose;
        #endregion

        #region unitycalls
        void Awake()
        {
            _initPose = _elementMove.transform.position;
        }
        #endregion

        #region private custom methods
        void IPlayerStayCollider.ToStayEventCollider()
        {
            float _pinpong = (Mathf.PingPong(Time.time *1* Time.deltaTime, 5));

            _elementMove.transform.position = new Vector3(_initPose.x - _pinpong ,               
                                                          _elementMove.transform.position.y,
                                                          _elementMove.transform.position.z);
        }
        void IPlayerExitCollider.ToExitEventCollider()
        {
            _elementMove.transform.position = _initPose;
        }
        #endregion
    }
}

