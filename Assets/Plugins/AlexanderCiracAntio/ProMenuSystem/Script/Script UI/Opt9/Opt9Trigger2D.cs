using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.Enum;
    [RequireComponent(typeof(BoxCollider2D))]
    public class Opt9Trigger2D : MonoBehaviour
    {
        #region Attributes
        private int _iD;
        private e_Opt9 _typeController;
        private e_Opt9State _typeState;
        #endregion

        #region UnityCalls
        void Start()
        {
            BoxCollider2D _collider = GetComponent<BoxCollider2D>();
            _collider.isTrigger = true;
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            if ( other.CompareTag("Player") )
            {
                Opt9Controller.Instance.OnActivatio?.Invoke(_iD , _typeController , _typeState);
            }
        }
        #endregion

        #region custom public methods
        public void SetOpt9Trigger2D(int _iD , e_Opt9 _typeController , e_Opt9State _typeState)
        {
            this._iD = _iD;
            this._typeController = _typeController;
            this._typeState = _typeState;
          
        }
        #endregion
    }
}
