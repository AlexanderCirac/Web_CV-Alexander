using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

namespace WebPage.UI
{
    public class SC_InicioUIController : MonoBehaviour
    {
          #region Attributes
          [System.Serializable]
          public class ButtonToChargeLevel
          {
            public Button _buttonToLoadLevel;
            public int _intLevel;
          }
          [Header("Buttons")]
          [SerializeField] private ButtonToChargeLevel[] _buttonToChargeLevel;
          #endregion

          #region UnityCalls
          // Start is called before the first frame update
          void Start()
          { 
              //Start Game
              Cursor.visible = true;
              Cursor.lockState = CursorLockMode.None;

              //Applying functions to ButtonToChargeLevel if there is
              int _raidButtons = 1, a = 0, b = 0, c= 0;
              for (; _raidButtons <= _buttonToChargeLevel.Length; _raidButtons++)
              { 
                  int _count = _raidButtons;
                  _buttonToChargeLevel[_raidButtons-1]._buttonToLoadLevel.onClick.AddListener(() => SceneManager.LoadScene(_buttonToChargeLevel[_count - 1]._intLevel));
              }
          }
          #endregion
    }
}
