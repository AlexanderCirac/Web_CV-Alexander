using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.Enum;
    [RequireComponent(typeof(BoxCollider2D))]
    public class PrM_TriggerUnlock2D : MonoBehaviour
    {
        #region Attributes
        public int _iD;
        public e_Opt8 _state;
        #endregion

        #region UnityCalls    
        private void Start()
        {
            BoxCollider2D _collider = GetComponent<BoxCollider2D>();
            _collider.isTrigger = true;
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if ( collision.CompareTag("Player") )
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
