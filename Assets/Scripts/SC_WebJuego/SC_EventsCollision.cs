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
                public float _lenght = 0;
                public float _velocity = 0;
           }

          [Header("Push Event")]
          [SerializeField] private VariableType2 _variablsToMove;
          [Header("Show Event")]
          [SerializeField] private GameObject _showObjects;

          private float _initialPos;

          //Events 
          public event Action<Transform, float , float> OnMovment;
          #endregion
          
          #region UnityCalls
          void Start()
          {
                if(_eventsEnum == EventsTypes.ShowEvent)
                    _showObjects.SetActive(false);

                if(_eventsEnum == EventsTypes.PushEvent)
                    _initialPos = _variablsToMove._moveObject.transform.position.x;

          }          
          void Update()
          {
              if (OnMovment != null)
                    OnMovment(_variablsToMove._moveObject.transform, _variablsToMove._lenght
                      ,_variablsToMove._velocity);
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
                          return;

                      //Teleporting
                      case EventsTypes.TeleportEvent:
                          coll.transform.position = _positionTeleportObject.transform.position;
                          return;

                      //Move object
                      case EventsTypes.PushEvent:
                          OnMovment += ToMove;
                          return;

                      //Show Object
                      case EventsTypes.ShowEvent:
                          ToShow(true);
                          return;
                  }
              }
          }

          private void OnTriggerExit(Collider coll)
          {   
              //Hidden Object
              if (_eventsEnum == EventsTypes.ShowEvent && coll.CompareTag("Player"))
                    ToShow(false);              

          }
          private void ToMove(Transform _originObject, float _lenght, float _velocity )
          {
                  _originObject.position = new Vector3(_initialPos - (Mathf.PingPong(Time.time * _velocity, _lenght) - 0.5f * _lenght), _originObject.position.y, _originObject.position.z); ;
              
                  if (_originObject.position.x > _initialPos *2 )
                  {
                      _originObject.position = new Vector3(_initialPos, _originObject.position.y, _originObject.position.z);
                      OnMovment -= ToMove;
                  }
          }
          private void ToShow(bool _boolShow) 
          { 
              _showObjects.SetActive(_boolShow);
          }
          #endregion
    }
}
