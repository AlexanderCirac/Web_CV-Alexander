using UnityEngine;

namespace WebGame.Game.Mechanical
{
    using WebCV.Tools.Interface;
    public class PushEvent : MonoBehaviour, IPlayerExitCollider, IPlayerStayCollider
    {

        #region Attributes
        //Set Objecto to move
        private  GameObject    _elementMove;
        private  Vector3     _initPose;
        #endregion

        #region unitycalls
        void Awake()
        {
            _elementMove = this.transform.GetChild(0).gameObject;
            _initPose = _elementMove.transform.position;
        }
        #endregion

        #region private custom methods
        public void ToStayEventCollider()
        {
            float _pinpong = (Mathf.PingPong(Time.time *1* Time.deltaTime, 5));

            _elementMove.transform.position = new Vector3(_initPose.x - _pinpong ,
                                                          _elementMove.transform.position.y ,
                                                          _elementMove.transform.position.z);
        }
        public void ToExitEventCollider()
        {
            _elementMove.transform.position = _initPose;
        }
        #endregion
    }
}

