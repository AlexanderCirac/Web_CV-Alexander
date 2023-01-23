using UnityEngine;

namespace WebPage
{
    using WebCV.Tools.Interface;
    public class ButtonURL : MonoBehaviour, IActionButton
    {

        #region Attributes
        [SerializeField] private string  _urlString;

        #endregion

        #region UnityCalls
        void IActionButton.ButtonAction()
        {
            Application.OpenURL(_urlString);
        }
        #endregion
    }
}
