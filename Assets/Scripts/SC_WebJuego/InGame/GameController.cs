using UnityEngine;
using UniRx;
using UnityEngine.SceneManagement;

namespace WebGame.Game
{
    public class GameController : MonoBehaviour
    {
        #region UnityCall
        void Start()
        {
            Observable.EveryUpdate()
                .Where(_ => Input.GetKeyDown(KeyCode.Alpha1))
                .Subscribe(_ => { SceneManager.LoadScene(1); });
        }
        #endregion
    }
}
