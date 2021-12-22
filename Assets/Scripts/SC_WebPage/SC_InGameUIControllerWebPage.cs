using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

namespace WebPage.UI 
{ 
    public class SC_InGameUIControllerWebPage : MonoBehaviour
    {     
          #region Attributes
          [Header("Buttons")]
          [SerializeField] private Button _toReturnMenu;
          [SerializeField] private Button _toLoadWebGame;
          #endregion          

          #region UnityCalls
          // Start is called before the first frame update
          void Start()
          {
              _toReturnMenu.onClick.AddListener(() => SceneManager.LoadScene(1));
              _toLoadWebGame.onClick.AddListener(() => SceneManager.LoadScene(5));
          }
          #endregion

          #region Methods
          //private void ChargeLevel(int level)
          //{
          //      SceneManager.LoadScene(level);
          //}
          #endregion
  }
}
