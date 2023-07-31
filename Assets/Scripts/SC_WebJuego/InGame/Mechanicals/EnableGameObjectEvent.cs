using UnityEngine;

namespace WebGame.Game.Mechanical
{
    using WebCV.Tools.Interface;
    public class EnableGameObjectEvent : MonoBehaviour, IPlayerEnterCollider, IPlayerExitCollider
    {
        #region Attributes
        //GameOjecto to set Active
        [HideInInspector]public GameObject _elementObservable;
        #endregion

        #region private custom methods
        public void ToEnterEventCollider(GameObject _player)
        {
            _elementObservable.SetActive(true);
        }        
        public void ToExitEventCollider()
        {
            _elementObservable.SetActive(false);
        }
        #endregion
    }
}