using UnityEngine;
using System;

namespace WebGame
{
    public class SC_EventsCollision : MonoBehaviour
    {
          #region Attributes
          [SerializeField] private EventsTypes _eventsEnum;
          [Header("URL Event")]
          [SerializeField] private string _urlText = "";
          [Header("Teleport Event")]
          [SerializeField] private GameObject _positionTeleportObject;          
          [System.Serializable] public class VariableType2 {
                public GameObject _moveObject;
                public GameObject _position1Object;
                public GameObject _position2Object;
                public float _velocity = 0;
           }

          [Header("Push Event")]
          [SerializeField] private VariableType2 _variablsToMove;
          [Header("Show Event")]
          [SerializeField] private GameObject _showObjects;
          //bool
          private bool _activateToMove = false;

          //Events 
          public event Action<Transform, Transform, Transform, float> OnMovment;
          #endregion
          
          #region UnityCalls
          void Start()
          {
                if(_eventsEnum == EventsTypes.ShowEvent)
                    _showObjects.SetActive(false);
          }          
          void Update()
          {
              if (OnMovment != null)
                    OnMovment(_variablsToMove._moveObject.transform, _variablsToMove._position1Object.transform, _variablsToMove._position2Object.transform, _variablsToMove._velocity);
          }
          #endregion

          #region Methods
          private void OnTriggerEnter(Collider coll)
          {
              if (coll.CompareTag("Player"))
              {
                  switch (_eventsEnum)
                  {
                      //Open URL
                      case EventsTypes.UrlEvent:
                          Application.OpenURL(_urlText);
                          break;

                      //Teleporting
                      case EventsTypes.TeleportEvent:
                          coll.transform.position = _positionTeleportObject.transform.position;
                          break;
                      //Move object
                      case EventsTypes.PushEvent:
                          _activateToMove = true;
                          OnMovment += ToMove;
                          break;

                      //Show Object
                      case EventsTypes.ShowEvent:
                          ToShow(true);
                          break;
                  }
              }
          }

          private void OnTriggerExit(Collider coll)
          {   
              //Hidden Object
              if (_eventsEnum == EventsTypes.ShowEvent && coll.CompareTag("Player"))
                    ToShow(false);
          }
          private void ToMove(Transform _originObject, Transform _destination1, Transform _destination2, float _velocity )
          {
              if (_activateToMove)
              {   
                  //Move forware
                  if (_originObject.position.x > _destination1.position.x )
                  {
                        _originObject.position = new Vector3(_originObject.position.x - _velocity * Time.deltaTime,
                        _originObject.position.y, 
                        _originObject.position.z);
                  }
                  else
                        _activateToMove = false;
              }
              else
              {   
                  // move back
                  if (_originObject.position.x < _destination2.position.x)
                  {
                       _originObject.position = new Vector3(_originObject.position.x + _velocity * Time.deltaTime,
                       _originObject.position.y, 
                       _originObject.position.z);
                  }
                  else
                  {
                       OnMovment -= ToMove;
                  }
              }
          }
          private void ToShow(bool _boolShow) 
          { 
              _showObjects.SetActive(_boolShow);
          }
          #endregion
    }
}
