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
          [System.Serializable] public class URL {
                public string _name;
                public Button _buttonToURL;
                public string _textToURL;
           }
          [Header("URL")]
          [SerializeField] private URL[] _variablsURL;
          #endregion          

          #region UnityCalls
          // Start is called before the first frame update
          void Start()
          {   
              //Button onClick
              _toReturnMenu.onClick.AddListener(() => SceneManager.LoadScene(1));
              _toLoadWebGame.onClick.AddListener(() => SceneManager.LoadScene(5));

              //Applying functions to URL if there is
              for (int _raidURL = 1; _raidURL <= _variablsURL.Length; _raidURL++)
              {
                  int _count = _raidURL;
                  _variablsURL[_raidURL-1]._buttonToURL.onClick.AddListener(() => Application.OpenURL(_variablsURL[_count - 1]._textToURL));
              }
          }
          #endregion
  }
}
