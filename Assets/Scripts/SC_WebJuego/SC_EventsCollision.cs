using UnityEngine;
using System;

namespace WebGame
{
    public class SC_EventsCollision : MonoBehaviour
    {
          #region Attributes
          [SerializeField] private EventsTypes _eventsEnum;
          [Header("Type Collision_0")]
          [SerializeField] private string _url = "";
          [Header("Type Collision_1")]
          [SerializeField] private GameObject _positionTeleportObject;          
          [System.Serializable] public class VariableType2 {
                public GameObject _moveObject;
                public GameObject _position1Object;
                public GameObject _position2Object;
                public float _velocity = 0;
           }

          [Header("TypeCollision_2")]
          [SerializeField] private VariableType2 _variablsToMove;
          private bool _activateCoroutine = false;
          private bool _activateToMove = false;
          [Header("Type Collision_3")]
          [SerializeField] private GameObject _showObjects;

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
                  //Open URL
                  if (_eventsEnum == EventsTypes.UrlEvent)
                      Application.OpenURL(_url);
                  
                  //Teleport to another side
                  if (_eventsEnum == EventsTypes.TeleportEvent && _positionTeleportObject != null)
                      coll.transform.position = _positionTeleportObject.transform.position;

                  //Move object how was a ping pong
                  if (_eventsEnum == EventsTypes.PushEvent)
                  {
                      _activateToMove = true;
                      OnMovment += ToMove;
                  }

                  //Show Object
                  if (_eventsEnum == EventsTypes.ShowEvent)
                       ToShow(true);
              }
          }

          private void OnTriggerExit(Collider coll)
          {
              if (_eventsEnum == EventsTypes.ShowEvent && coll.CompareTag("Player"))
                    ToShow(false);
          }
          private void ToMove(Transform _originObject, Transform _destination1, Transform _destination2, float _velocity )
          {
              if (_activateToMove)
              {
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
