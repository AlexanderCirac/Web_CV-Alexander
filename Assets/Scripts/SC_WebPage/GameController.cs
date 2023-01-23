using UnityEngine;
using UnityEngine.UI;

namespace WebPage
{
    using WebCV.Tools.Interface;
    public class GameController : MonoBehaviour
    {
        #region Attributes
        [SerializeField] private Button[]  _buttons;
        #endregion

        #region UnityCalls
        private void Start()
        {
            for ( int _raidButtons = 1 ; _raidButtons <= _buttons.Length ; _raidButtons++ )
            {               
                if ( _buttons[_raidButtons - 1].TryGetComponent(out IActionButton _iActionButton) )
                {
                    _buttons[_raidButtons - 1].onClick.AddListener(() => _iActionButton.ButtonAction());                   
                }
            }
        }
        #endregion
    }
}
