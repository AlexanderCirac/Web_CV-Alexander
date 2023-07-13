using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexanderCA.ProMenu.Generic
{
    public class SingletonGeneric<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;
        public static bool _createGameObjectIfMissing { get; set; }
        public static T Instance
        {
            get
            {
                if ( _instance == null )
                {
                    _instance = FindObjectOfType<T>();
                    if ( _instance == null )
                    {
                       
                        if ( _createGameObjectIfMissing )
                        {
                            GameObject go = new GameObject(typeof(T).Name);
                            _instance = go.AddComponent<T>();
                        }
                        else
                        Debug.LogError($"An instance of {typeof(T)} is needed in the scene, but there is none.");                        
                    }
                }
                return _instance;
            }
        }

        public virtual void DontDestroy()
        {
            if ( _instance == null )
            {
                _instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

}
