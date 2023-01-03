using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

namespace WebPage.Page.UI
{
    public class SC_InicioUIControllerWebPage : MonoBehaviour
    {
        #region Attributes
        [System.Serializable]
        public class ButtonToChargeLevel
        {
            public Button _loadLevelButton;
            public int _iDLevel;
        }
        [Header("Buttons")]
        [SerializeField] ButtonToChargeLevel[] _variableToChargeLevel;
        #endregion

        #region UnityCalls
        void Awake() => Init();
        #endregion

        #region Methods
        private void Init()
        {
            //Start Game
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            //Applying load level function
            for ( int _raidButtons = 1 ; _raidButtons <= _variableToChargeLevel.Length ; _raidButtons++ )
            {
                int _count = _raidButtons;
                _variableToChargeLevel[_raidButtons - 1]._loadLevelButton.onClick.AddListener(() => SceneManager.LoadScene(_variableToChargeLevel[_count - 1]._iDLevel));
            }
        }
        #endregion
    }
}
