using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.Enum;
    [RequireComponent(typeof(BoxCollider))]
    public class PrM_TriggerUnlock3D : MonoBehaviour
    {
        #region Attributes
        public int _iD;
        public e_Opt8 _state;
        #endregion

        #region UnityCalls     
        void Start()
        {
            BoxCollider _collider = GetComponent<BoxCollider>();
            _collider.isTrigger = true;
        }
        private void OnTriggerEnter(Collider other)
        {
            if ( other.CompareTag("Player") )
            {
                if ( _state == e_Opt8.Unlock )
                    PrM_Unlock.UnLockID(_iD);
                else if ( _state == e_Opt8.Lock )
                    PrM_Unlock.LockID(_iD);
            }
        }

        #endregion
    }
}
