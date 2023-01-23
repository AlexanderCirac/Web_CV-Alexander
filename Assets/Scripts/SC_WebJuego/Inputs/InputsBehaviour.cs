using UnityEngine;

// esta scritp será para heredar y les pasaras las funciones basicas para crear un controlador de inputs
namespace WebGame.Game.Inputs
{
    public abstract class InputsBehaviour : MonoBehaviour
    {
        public abstract float GetHorizontal();
        public abstract float GetVertical();
        public abstract float GetJump();
        public abstract float GetRotationVertical();
        public abstract float GetRotationHorizontal();
    }
}
