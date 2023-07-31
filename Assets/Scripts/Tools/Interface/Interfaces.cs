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
    public interface IInputs
    {
        public float GetVertical();
        public float GetHorizontal();
        public float GetRotationVertical();
        public float GetRotationHorizontal();
        public float GetJump();
    }
}
