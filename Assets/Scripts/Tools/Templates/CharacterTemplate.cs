using UnityEngine;
using UniRx;
using Zenject;

namespace WebGame.Game.Templates
{
    using WebCV.Tools.Interface;
    public abstract class CharacterTemplate : MonoBehaviour
    {
        #region Attributes
        [Header("Inputs to controller Character")]
        [Inject(Id ="Player")]
        public IInputs _inputs;
        #region Delegates 
        public delegate void MydelegateMovement();
        public MydelegateMovement _delegateInputsMovement { get; set; }

        public delegate void MydelegateRotate();
        public MydelegateRotate _delegateInputsRotate { get; set; }

        public delegate void MydelegateJump();
        public MydelegateJump _delegateInputsJump { get; set; }
        #endregion
        #endregion

        #region UnityCalls
        private void Awake()
        {
            Observable.EveryUpdate().Where(_ => _inputs.GetJump() != 0).Subscribe(_ => _delegateInputsJump?.Invoke());
            _delegateInputsJump += ToJumping;
            Observable.EveryUpdate().Where(_ => _inputs.GetHorizontal() != 0 || _inputs.GetVertical() != 0).Subscribe(_ => _delegateInputsMovement?.Invoke());
            _delegateInputsMovement += ToMovement;
            Observable.EveryUpdate().Where(_ => _inputs.GetRotationHorizontal() != 0 || _inputs.GetRotationVertical() != 0).Subscribe(_ => _delegateInputsRotate?.Invoke());
            _delegateInputsRotate += ToRotate;
        }
        private void OnDestroy()
        {
            _delegateInputsJump -= ToJumping;
            _delegateInputsMovement -= ToMovement;
            _delegateInputsRotate -= ToRotate;
        }
        #endregion

        #region abstract customs methods
        protected abstract void ToMovement();
        protected abstract void ToJumping();
        protected abstract void ToRotate();
        #endregion
    }
}
