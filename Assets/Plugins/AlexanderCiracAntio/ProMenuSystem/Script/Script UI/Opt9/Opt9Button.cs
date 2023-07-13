using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.Enum;
    public class Opt9Button : MonoBehaviour
    {
        #region Attributes
        private int _iD;
        private e_Opt9 _typeController;
        private e_Opt9State _typeState;
        #endregion

        #region custom public methods
        public void SetOpt9Button(int _iD , e_Opt9 _typeController , e_Opt9State _typeState)
        {
            this._iD = _iD;
            this._typeController = _typeController;
            this._typeState = _typeState;
            GetComponent<Button>().onClick.AddListener(ActionButton);
        }
        
        #endregion

        #region custom private methods
        void ActionButton()
        {
            Opt9Controller.Instance.OnActivatio?.Invoke(_iD , _typeController , _typeState);
        }
        #endregion
    }
}
