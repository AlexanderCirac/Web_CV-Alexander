using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace WebGame.Game.Mechanical
{
    using WebGame.Game;
    public class PushGameobject : MonoBehaviour/*, IEventCollider*/
    {


        #region Attributes
        Vector3 _posInt;
        #endregion

        #region UnityCalls
        // Start is called before the first frame update
         
        void OnTriggerEnter(Collider col) {

            if ( col.CompareTag("Player") )
            {
                ToEventCollider(EventsTypes.PushEvent);
                _posInt = this.transform.position;

            }
        }       
        void OnTriggerExit(Collider col) {

            this.transform.position = _posInt;
        }

        #endregion

        #region Methods

        public void ToEventCollider(EventsTypes a)
        {
            this.transform.position = new Vector3(Mathf.PingPong(-5 , 5) , this.transform.position.y , this.transform.position.x);
        }
        #endregion
    }
}

