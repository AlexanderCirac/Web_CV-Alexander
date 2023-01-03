using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

namespace WebPage.Page.UI
{
    public class SC_InGameUIControllerWebPage : MonoBehaviour
    {
        #region Attributes
        [Header("Buttons")]
        [SerializeField] Button _menuButton;
        [SerializeField] Button _webGameButton;
        [System.Serializable]
        public class URL
        {
            public string _name;
            public Button _urlButton;
            public string _urlText;
        }
        [Header("URL")]
        [SerializeField]  URL[] _variablesToOpenURL;
        #endregion

        #region UnityCalls
        void Awake() => Init();
        #endregion

        #region Methods
        private void Init()
        {
            //Button onClick
            _menuButton.onClick.AddListener(() => SceneManager.LoadScene(1));
            _webGameButton.onClick.AddListener(() => SceneManager.LoadScene(5));

            //Applying URL function
            for ( int _raidURL = 1 ; _raidURL <= _variablesToOpenURL.Length ; _raidURL++ )
            {
                int _count = _raidURL;
                _variablesToOpenURL[_raidURL - 1]._urlButton.onClick.AddListener(() => Application.OpenURL(_variablesToOpenURL[_count - 1]._urlText));
            }
        }
        #endregion
    }
}
