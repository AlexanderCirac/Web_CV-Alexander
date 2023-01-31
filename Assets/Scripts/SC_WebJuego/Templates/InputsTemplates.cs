using UnityEngine;
using UniRx;

namespace WebGame.Game.Templates
{
    public abstract class InputsTemplates : MonoBehaviour
    {
        internal delegate void MydelegateMovement();
        internal MydelegateMovement  _delegateInputsMovement;

        internal delegate void MydelegateRotate();
        internal MydelegateRotate    _delegateInputsRotate;

        internal delegate void MydelegateJump();
        internal MydelegateJump      _delegateInputsJump;

        #region abstract customs methods
        public abstract float GetHorizontal();
        public abstract float GetVertical();
        public abstract float GetJump();
        public abstract float GetRotationVertical();
        public abstract float GetRotationHorizontal();

        #endregion
    }
}
