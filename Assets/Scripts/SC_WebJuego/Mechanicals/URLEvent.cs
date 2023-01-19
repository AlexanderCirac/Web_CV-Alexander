using UnityEngine;

namespace WebGame.Game.Mechanical
{
    public class URLEvent : MonoBehaviour, IPlayerEnterCollider
    {
        #region Attributes
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
