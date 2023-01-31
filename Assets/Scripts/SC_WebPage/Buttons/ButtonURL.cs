using UnityEngine;

namespace WebPage
{
    using WebCV.Tools.Interface;
    public class ButtonURL : MonoBehaviour, IActionButton
    {

        #region Attributes
        [Header("URL Link")]
        [SerializeField] private string  _urlString;

        #endregion

        #region Interfaces
        void IActionButton.ButtonAction()
        {
            Application.OpenURL(_urlString);
        }
        #endregion
    }
}
