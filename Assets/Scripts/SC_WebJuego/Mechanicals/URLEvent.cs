using UnityEngine;

namespace WebGame.Game.Mechanical
{
    using WebCV.Tools.Interface;
    public class URLEvent : MonoBehaviour, IPlayerEnterCollider
    {
        #region Attributes
        [Header("URL Link")]
        [SerializeField] private string _urlText;
        #endregion

        #region private custom methods
        void IPlayerEnterCollider.ToEnterEventCollider(GameObject _player)
        {
            Application.OpenURL(_urlText);
        }
        #endregion
    }
}
