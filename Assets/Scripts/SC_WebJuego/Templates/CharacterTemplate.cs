using UnityEngine;
using UniRx;

namespace WebGame.Game.Templates
{

    public abstract class CharacterTemplate : MonoBehaviour
    {
        #region Attributes
        public InputsTemplates _inputs;
        #endregion

        #region UnityCalls

        private void Awake()
        {
            TryGetComponent(out _inputs);
            Observable.EveryUpdate().Where(_ => _inputs.GetJump() != 0).Subscribe(_ => _inputs._delegateInputsJump?.Invoke());
            _inputs._delegateInputsJump += ToJumping;
            Observable.EveryUpdate().Where(_ => _inputs.GetHorizontal() != 0 || _inputs.GetVertical() != 0).Subscribe(_ => _inputs._delegateInputsMovement?.Invoke());
            Observable.EveryUpdate().Where(_ => _inputs.GetRotationHorizontal() != 0 || _inputs.GetRotationVertical() != 0).Subscribe(_ => _inputs._delegateInputsRotate?.Invoke());
        }
        private void OnDestroy()
        {
            _inputs._delegateInputsJump = ToJumping;
            
        }
        //private void Update()
        //{
        //    ToMovement();
        //    ToJumping();
        //    ToRotate();
        //}
        #endregion

        #region abstract customs methods
        protected abstract void ToMovement();
        protected abstract void ToJumping();
        protected abstract void ToRotate();
        #endregion
    }
}
