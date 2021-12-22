using UnityEngine;
using System;
using System.Collections;

namespace WebGame
{
    public class SC_EventsCollision : MonoBehaviour
    {
          #region Attributes
          [SerializeField] private int _idTypeEvent = 0;
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
          private bool _activateCoroutine = false;
          private bool _activateToMove = false;
          [Header("Type_3")]
          [SerializeField] private GameObject _objectToShow;

          //Events 
          public event Action OnMovment;
          #endregion
          
          #region UnityCalls
          void Start()
          {
                if(_idTypeEvent == 3)
                    _objectToShow.SetActive(false);
          }
          #endregion

          #region Methods
          private void OnTriggerEnter(Collider coll)
          {
              if (coll.CompareTag("Player"))
              { 
                  //Open URL
                  if (_idTypeEvent == 0)
                      Application.OpenURL(_url);
                  
                  //Teleport to another side
                  if (_idTypeEvent == 1 && _zonetToTeleport != null)
                      coll.transform.position = _zonetToTeleport.transform.position;
                  //Move object 
                  if (_idTypeEvent == 2)
                  {
                      _activateToMove = true;
                      _activateCoroutine = true;
                      OnMovment += ApplicateMovement;
                      StartCoroutine(CoroutineOnMovment());
                  }
                  //Show Object
                  if (_idTypeEvent == 3)
                       ShowObjects(true);
              }
          }

          private void OnTriggerExit(Collider coll)
          {
              if (_idTypeEvent == 3 && coll.CompareTag("Player"))
                      ShowObjects(false);
          }

          IEnumerator CoroutineOnMovment()
          {
              while(_activateCoroutine)
              {
                if (OnMovment != null)
                    OnMovment();
                    yield return null;
              }
          }

          public void ApplicateMovement()
          {
              if(_variablsToMove._objectToMove != null && _variablsToMove._objectToPos1 != null && _variablsToMove._objectToPos2 != null && _variablsToMove._velocity != 0)
              ToMove(_variablsToMove._objectToMove, _variablsToMove._objectToPos1, _variablsToMove._objectToPos2, _variablsToMove._velocity);
          }

          public void ToMove(GameObject _Object,GameObject _obj1, GameObject _obj2, float _velocity )
          {
              if (_activateToMove)
              {
                  if (_Object.transform.position.x > _obj1.transform.position.x )
                  {
                        _Object.transform.position = new Vector3(_Object.transform.position.x - _velocity * Time.deltaTime,
                        _Object.transform.position.y, 
                        _Object.transform.position.z);
                  }
                  else
                        _activateToMove = false;
              }
              else
              {
                  if (_Object.transform.position.x < _obj2.transform.position.x)
                  {
                       _Object.transform.position = new Vector3(_Object.transform.position.x + _velocity * Time.deltaTime,
                       _Object.transform.position.y, 
                       _Object.transform.position.z);
                  }
                  else
                  {
                       _activateCoroutine = false;
                       OnMovment -= ApplicateMovement;
                  }
              }
          }

          private void ShowObjects(bool _activateShow) 
          { 
              _objectToShow.SetActive(_activateShow);
          }
          #endregion
    }
}
