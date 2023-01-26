using UnityEngine;

namespace WebGame.Game.Inputs
{
    public abstract class InputsTemplates : MonoBehaviour
    {
        public abstract float GetHorizontal();
        public abstract float GetVertical();
        public abstract float GetJump();
        public abstract float GetRotationVertical();
        public abstract float GetRotationHorizontal();
    }
}
