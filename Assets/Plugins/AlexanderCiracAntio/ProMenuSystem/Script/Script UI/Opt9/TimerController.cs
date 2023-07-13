using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;


namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.Enum;
    public class TimerController : MonoBehaviour
    {
        #region Attributes
        private int _iD;
        private e_Opt9 _typeController;
        private e_Opt9State _type;
        private UnityEvent _beginigEvent;
        private UnityEvent _endingEvent;
        private TextMeshProUGUI _meshProTxt;
        private Text _legacyText;
        private Image _effectImage;
        private Sprite[] _differentsSprites;
        private bool _efectSmall;
        private float _maxTimer;
        private float _currentTimer;
        private bool _isBeginingTimer;
        private bool _isDecreaceTimer;

        private Vector3 _initiScale;
        #endregion

        #region UnityCalls
        private void Start()
        {
            Opt9Controller.Instance.OnActivatio += ToTimerAction;
            if ( _isBeginingTimer )
            {
                StartCoroutine(IEBeginign());

            }
            VisualEffect();
        }
        private void OnDestroy()
        {

            Opt9Controller.Instance.OnActivatio -= ToTimerAction;
        }
        #endregion

        #region custom public methods
        public void SetTimerController(int _iD , e_Opt9 _typeController , UnityEvent _beginigEvent , UnityEvent _endingEvent , TextMeshProUGUI _meshProTxt , Text _legacyText , Image _effectImage ,
         Sprite[] _differentsSprites , bool _efectSmall , float _maxTimer , bool _isbeginingTimer , bool _isdecreaceTimer)
        {
            this._iD = _iD;
            this._typeController = _typeController;
            this._beginigEvent = _beginigEvent;
            this._endingEvent = _endingEvent;
            this._meshProTxt = _meshProTxt;
            this._legacyText = _legacyText;
            this._maxTimer = _maxTimer;
            this._isBeginingTimer = _isbeginingTimer;
            this._isDecreaceTimer = _isdecreaceTimer;
            this._effectImage = _effectImage;
            this._differentsSprites = _differentsSprites;
            this._efectSmall = _efectSmall;
            if ( _isdecreaceTimer )
                _currentTimer = _maxTimer;
            if ( _effectImage )
                _initiScale = _effectImage.transform.localScale;
            if ( _isBeginingTimer )
            {
                _type = e_Opt9State.begining;
            }
        }
        #endregion

        #region custom private methods
        void ToTimerAction(int _iD , e_Opt9 _typeController , e_Opt9State _typeState)
        {
            if ( _iD == this._iD && _typeController == this._typeController )
            {
                _type = _typeState;

                switch ( _typeState )
                {
                    case e_Opt9State.begining:
                        StartCoroutine(IEBeginign());
                        break;
                    case e_Opt9State.ending:
                        ToEnding();
                        break;
                    default:
                        break;
                }
            }
        }

        IEnumerator IEBeginign()
        {

            _beginigEvent?.Invoke();
            if ( _type == e_Opt9State.begining )
            {
                float valueMax =  _currentTimer < _maxTimer ?  _maxTimer +1 : _maxTimer;
                _currentTimer = _isDecreaceTimer ? valueMax : 0;
            }
            while ( _type == e_Opt9State.begining )
            {
                if ( !_isDecreaceTimer && _currentTimer < _maxTimer )
                {

                    yield return new WaitForSeconds(1f);
                    if ( _type == e_Opt9State.begining )
                    {
                        _currentTimer += 1;
                        VisualEffect();
                    }
                }
                if ( _isDecreaceTimer && _currentTimer > 0 )
                {
                    yield return new WaitForSeconds(1f);
                    if ( _type == e_Opt9State.begining )
                    {
                        _currentTimer -= 1;
                        VisualEffect();
                    }
                }
                yield return null;
            }
            ToEnding();
        }
        void ToEnding()
        {
            StopCoroutine(IEBeginign());
            _endingEvent?.Invoke();
        }
        void VisualEffect()
        {
            if ( _effectImage )
            {
                float _numeroParadas = _differentsSprites.Length > 0 ? _differentsSprites.Length : 2;
                int currentStop = Mathf.FloorToInt((_currentTimer * _numeroParadas) / _maxTimer);
                if ( _differentsSprites.Length > 0 && _currentTimer < _maxTimer && _effectImage.sprite != _differentsSprites[currentStop] )
                {

                    _effectImage.sprite = _differentsSprites[currentStop];
                }

                if ( idStep != currentStop && _efectSmall && _currentTimer < _maxTimer )
                {
                    StartCoroutine(SmallEffect(_maxTimer / _numeroParadas));
                    idStep = currentStop;
                }
                else if ( _currentTimer < _maxTimer )
                {
                    StopCoroutine(SmallEffect(_maxTimer / _numeroParadas));
                }
            }
            if ( _meshProTxt )
                _meshProTxt.GetComponent<TextMeshProUGUI>().text = ( (int) _currentTimer ).ToString();

            if ( _legacyText )
                _legacyText.GetComponent<Text>().text = ( (int) _currentTimer ).ToString();

            if ( !_isDecreaceTimer && _currentTimer == _maxTimer || _isDecreaceTimer && _currentTimer == 0 )
            {
                _type = e_Opt9State.ending;
                ToEnding();
            }
        }
        int idStep = -1;
        IEnumerator SmallEffect(float tiempo)
        {
            _effectImage.transform.localScale = _initiScale;
            float _timerCurrutine= 0;
            while ( _timerCurrutine < tiempo )
            {
                _timerCurrutine += Time.deltaTime;
                float t = Mathf.Clamp01(_timerCurrutine / tiempo);
                _effectImage.transform.localScale = Vector3.Lerp(_initiScale , Vector3.zero , t);
                yield return null;
            }
        }
        #endregion
    }
}
