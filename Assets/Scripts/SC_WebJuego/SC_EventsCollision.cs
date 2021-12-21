using UnityEngine;
using System;

namespace WebCVAlexGame
{
    public class SC_EventsCollision : MonoBehaviour
    {
          #region Attributes
          [SerializeField] private int _typeEvent = 0;
          [Header("Type_0")]
          [SerializeField] private string _url = "";
          [Header("Type_1")]
          [SerializeField] private GameObject _zonetToTeleport;
          [System.Serializable] public class VariableType2 {
                public GameObject _objectToMove;
                public GameObject _objectToPos1;
                public GameObject _objectToPos2;
                public float _velocity = 0;
           }
          
          [Header("Type_2")]
          [SerializeField] private VariableType2 _variablsToMove;

          //Events 
          public event Action OnMovment;
    #endregion

          #region Methods
          private void OnTriggerEnter(Collider coll)
          {
              if (coll.CompareTag("Player"))
              { 
                  //Open URL
                  if (_typeEvent == 0)
                      Application.OpenURL(_url);
                  
                  //Teleport to another side
                  if (_typeEvent == 1 && _zonetToTeleport != null)
                      coll.transform.position = _zonetToTeleport.transform.position;  
                  
                  //if (_typeEvent == 2 /*&& OnMovment != null*/)
                      
                    
              }
          }

          public void ApplicateMovement()
          {
 
              if(_variablsToMove._objectToMove != null && _variablsToMove._objectToPos1 != null && _variablsToMove._objectToPos2 != null && _variablsToMove._velocity != 0)
              ToMove(_variablsToMove._objectToMove, _variablsToMove._objectToPos1, _variablsToMove._objectToPos2, true, _variablsToMove._velocity);
          }

          public void ToMove(GameObject _Object,GameObject _obj1, GameObject _obj2, bool _activate, float _velocity )
          {
      
              if (_activate)
              {
                  if (_Object.transform.position.x > _obj1.transform.position.x)
                  {
                        _Object.transform.position = new Vector3(_Object.transform.position.x - _velocity * Time.deltaTime,
                        _Object.transform.position.y, 
                        _Object.transform.position.z);

                  }
                  else
                       _activate = false;
              }
              else
              {
                  if (_Object.transform.position.x < _obj2.transform.position.x)
                  {
                       _Object.transform.position = new Vector3(_Object.transform.position.x + _velocity * Time.deltaTime,
                       _Object.transform.position.y, 
                       _Object.transform.position.z);
            
                  }
                  
                      OnMovment -= ApplicateMovement;
              }
          }
    #endregion
    }

}
