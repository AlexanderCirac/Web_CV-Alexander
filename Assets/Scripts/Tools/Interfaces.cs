using UnityEngine;

namespace WebCV.Tools.Interface
{
    public interface IPlayerStayCollider
    {
        public void ToStayEventCollider();
    }
    public interface IPlayerEnterCollider
    {
        public void ToEnterEventCollider(GameObject _player);
    }
    public interface IPlayerExitCollider
    {
        public void ToExitEventCollider();
    }

    public interface IActionButton
    {
        public void ButtonAction();
    }
}
