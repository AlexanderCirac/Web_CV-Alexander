using UnityEngine;
using System;

namespace WebGame
{
    public class SC_EventsCollision : MonoBehaviour
    {
          #region Attributes
          [SerializeField]  EventsTypes _eventsEnum;
          [Header("URL Event")]
          [SerializeField]  string _urlText = "";
          [Header("Teleport Event")]
          [SerializeField]  GameObject _positionTeleportObject;          
          [System.Serializable] public class VariableType2 {
                public GameObject _moveObject;
                public float _lenght = 0;
                public float _velocity = 0;
           }

          [Header("Push Event")]
          [SerializeField]  VariableType2 _variablsToMove;
          [Header("Show Event")]
          [SerializeField]  GameObject _showObjects;

          float _initialPos;

          //Events 
          public event Action<Transform, float , float> OnMovment;
          #endregion
          
          #region UnityCalls
          void Awake() => Init(_eventsEnum);
      
          void Update() => OnMovment?.Invoke(_variablsToMove._moveObject.transform, _variablsToMove._lenght,_variablsToMove._velocity);
          private void OnTriggerExit(Collider coll)
          {   
              //Hidden Object
              if (coll.CompareTag("Player"))
                    ToShow = false;              
          }
          #endregion

          #region Methods
          private void Init(EventsTypes eventsTypes)
          {
                  switch (eventsTypes)
                  {
                      //Move object
                      case EventsTypes.PushEvent:
                          _initialPos = _variablsToMove._moveObject.transform.position.x;
                          return;

                      //Show Object
                      case EventsTypes.ShowEvent:
                          ToShow = false;
                          return;
                  }
          }
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
                          ToShow = true;
                          return;
                      default :
                          return;
                  }
              }
          }
          private void ToMove(Transform _originObject, float _lenght, float _velocity )
          {
 
                      _originObject.position = _originObject.position.x > _initialPos * 2 ?  new Vector3(_initialPos, _originObject.position.y, _originObject.position.z) : new Vector3(_initialPos - (Mathf.PingPong(Time.time * _velocity, _lenght) - 0.5f * _lenght), _originObject.position.y, _originObject.position.z);
                      
                      if(_originObject.position.x > _initialPos * 2)
                      OnMovment -= ToMove;
                  
          }
          private bool ToShow
          {
              set
              {     
                  if(value && _eventsEnum == EventsTypes.ShowEvent)
                      _showObjects.SetActive(value);
              }
          }
          
          #endregion
    }
}
