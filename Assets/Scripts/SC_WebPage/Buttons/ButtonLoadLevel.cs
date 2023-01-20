using UnityEngine;
using UnityEngine.SceneManagement;

namespace WebPage
{
    using WebPage.Interfaces;
    public class ButtonLoadLevel : MonoBehaviour, IActionButton
    {
        #region Attributes
        [SerializeField] private int  _idScene;
        #endregion

        #region UnityCalls
        void IActionButton.ButtonAction()
        {
            SceneManager.LoadScene(_idScene);
        }
        #endregion
    }
}
