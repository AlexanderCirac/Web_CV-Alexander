using UnityEngine;
using UniRx;

namespace WebGame.Game.Inputs
{
    public class InputsController : MonoBehaviour
    {
        #region Attributes
        [Header("Get current Input to cotroller")]
        [SerializeField] private InputsTemplates _inputs;

        //Events to call what do
        internal delegate  void  MydelegateMovement(float _x , float _y);
        internal MydelegateMovement  _delegateInputsMovement;

        internal delegate  void  MydelegateRotate(float _x , float _y);
        internal MydelegateRotate    _delegateInputsRotate;

        internal delegate  void  MydelegateJump();
        internal MydelegateJump      _delegateInputsJump;
        #endregion  

        #region UnityCalls       
        void Start()
        {
            if ( _inputs == null )
            {
                Debug.Log($"Net Inputs Data");
                return;
            }
            Observable.EveryUpdate().Where(_ => _inputs.GetJump() != 0).Subscribe(_ => ToEventJump(_delegateInputsJump));
            Observable.EveryUpdate().Where(_ => _inputs.GetHorizontal() != 0 || _inputs.GetVertical() != 0).Subscribe(_ => ToEventMovement(_delegateInputsMovement));
            Observable.EveryUpdate().Where(_ => _inputs.GetRotationHorizontal() != 0 || _inputs.GetRotationVertical() != 0).Subscribe(_ => ToEventRotate(_delegateInputsRotate));
        }
        #endregion

        #region privats customs methods
        void ToEventJump(MydelegateJump _myDelegateJump)
        {
            _myDelegateJump?.Invoke();
        }
        void ToEventMovement(MydelegateMovement _mydelegateMovement)
        {
            _mydelegateMovement?.Invoke(_inputs.GetHorizontal() , _inputs.GetVertical());
        }
        void ToEventRotate(MydelegateRotate _delegateInputsRotate)
        {
            _delegateInputsRotate?.Invoke(_inputs.GetRotationHorizontal() , _inputs.GetRotationVertical());
        }
        #endregion
    }
}
