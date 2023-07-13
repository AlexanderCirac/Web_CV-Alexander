using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.UI
{
    public class PrM_UnlockButton : MonoBehaviour
    {

        #region Attributes
        private PrM_UnlockController _unlockController;
        private int _idElement = 0;
        private Sprite _unlockSprite;
        private Sprite _lockSprite;

        #endregion

        #region UnityCalls
        void Start() => _unlockController._OnUnlockController += ToStateUnlockUI;
        private void OnDestroy() => _unlockController._OnUnlockController -= ToStateUnlockUI;
        #endregion

        #region Costum private Methods     

        void ToStateUnlockUI(int _id , bool _isUnlock)
        {
            if ( _id == _idElement )
            {
                Sprite _imageLock = _lockSprite != null ?_lockSprite : null ;
                Sprite _imageUnlock = _unlockSprite != null ? _unlockSprite : null;
                GetComponent<Button>().interactable = _isUnlock;
                GetComponent<Image>().sprite = _isUnlock ? _imageUnlock : _imageLock;
            }
        }
        public void SetStateUnlock(PrM_UnlockController _unlockController , int _idElement , Sprite _unlockSprite , Sprite _lockSprite)
        {

            this._unlockController = _unlockController;
            this._idElement = _idElement;
            this._unlockSprite = _unlockSprite;
            this._lockSprite = _lockSprite;
        }
        #endregion

    }
}
