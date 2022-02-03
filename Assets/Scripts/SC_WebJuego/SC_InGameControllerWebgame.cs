using UnityEngine;
using UnityEngine.SceneManagement;

namespace WebGame
{ 
    public class SC_InGameControllerWebGame : MonoBehaviour
    {
         #region UnityCall
        void Update()
        {
            //Load to level's WebPage
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                  SceneManager.LoadScene(1);
            }
        }
        #endregion

    }
}
