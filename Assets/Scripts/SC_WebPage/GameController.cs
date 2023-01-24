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
            if ( _buttons.Length != 0 ) return;
            for ( int _raidButtons = 0 ; _raidButtons <= _buttons.Length ; _raidButtons++ )
            {               
                if ( _buttons[_raidButtons].TryGetComponent(out IActionButton _iActionButton) )
                {
                    _buttons[_raidButtons].onClick.AddListener(() => _iActionButton.ButtonAction());                   
                }
            }
        }
        #endregion
    }
}
