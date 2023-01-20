using UnityEngine;

namespace WebPage
{
    using WebPage.Interfaces;
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
