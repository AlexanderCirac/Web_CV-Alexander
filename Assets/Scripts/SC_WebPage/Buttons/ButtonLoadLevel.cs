using UnityEngine;
using UnityEngine.SceneManagement;

namespace WebPage
{
    using WebCV.Tools.Interface;
    public class ButtonLoadLevel : MonoBehaviour, IActionButton
    {
        #region Attributes
        [Header("Sel Level to Loaded")]
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
