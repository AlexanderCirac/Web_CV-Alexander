using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.ToolsInspector;
    using AlexanderCA.ProMenu.Enum;
    using UnityEngine.SceneManagement;

    [System.Serializable]
    public struct PrM_TimersInfo
    {
        #region Unlock Explanation

        public ExplicacionTimers _explication;
        public ContentTimers _content;

        [System.Serializable]
        public struct ExplicacionTimers
        {
            public ExplicacionTimersEspañol Español;
            public ExplicacionTimersIngles English;
        }

        #region Spanish
        [System.Serializable]
        public struct ExplicacionTimersEspañol
        {
            public TimersEspañol Explicación;
            public TimersUsoEspañol Uso;
            public TimersAdvertenciaEspañol Advertencia;
        }
        [System.Serializable]
        public struct TimersEspañol
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("En esta sección se encuentra la funcionalidad de creación de temporizadores o cuentas regresivas para diversos propósitos, tales como la iniciación de una partida, un combate o la finalización de un nivel o evento específico.Esta herramienta proporciona una forma eficiente de gestionar el tiempo y mantener el control sobre dichos eventos del juego. USO: consiste en establecer el tiempo máximo deseado para el temporizador o cuenta regresiva, indicar su ubicación visual y especificar los métodos que se llamarán cuando se activen o finalicen dichos eventos. Esta herramienta proporciona una forma eficiente de gestionar el tiempo y mantener el control sobre los procesos en curso. Advertencia :Es importante que cada temporizador tenga asignado una menera de ser inicializada, las opciones de asingar lectura de evento al ser activada o desactivada, las diferentes maneras de como visualizar dicho temporizador o otras formas de controlar cuando activar o desactivar son opcionales, no es necesario rellenarlos", UnityEditor.MessageType.Info)]
            public bool _a;
#endif
        }

        [System.Serializable]
        public struct TimersUsoEspañol
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("Uso: consiste en establecer el tiempo máximo deseado para el temporizador o cuenta regresiva, indicar su ubicación visual y especificar los métodos que se llamarán cuando se activen o finalicen dichos eventos. Esta herramienta proporciona una forma eficiente de gestionar el tiempo y mantener el control sobre los procesos en curso.", UnityEditor.MessageType.Warning)]
            public bool _a;
#endif
        }
        [System.Serializable]
        public struct TimersAdvertenciaEspañol
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("Advertencia: Es importante que cada temporizador tenga asignado una menera de ser inicializada, las opciones de asingar lectura de evento al ser activada o desactivada, las diferentes maneras de como visualizar dicho temporizador o otras formas de controlar cuando activar o desactivar son opcionales, no es necesario rellenarlos.", UnityEditor.MessageType.Error)]
            public bool _a;
#endif
        }
        #endregion


        #region English
        [System.Serializable]
        public struct ExplicacionTimersIngles
        {
            public TimersTotalIngles Explanation;
            public TimersUsoIngles Use;
            public TimersAdvertenciaIngles Warning;
        }
        [System.Serializable]
        public struct TimersTotalIngles
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("This section contains functionality for creating timers or countdowns for various purposes, such as starting a match, combat, or finishing a specific level or event. This tool provides an efficient way to manage time and keep control over said game events. USE: Consists of setting the desired maximum time for the timer or countdown, indicating its visual location, and specifying the methods that will be called when those events are triggered or terminated. This tool provides an efficient way to manage time and maintain control over ongoing processes. Warning: It is important that each timer is assigned a way to be initialized, the options to assign event reading when activated or deactivated, the different ways to display said timer or other ways to control when to activate or deactivate are optional, it is not need to fill them out.", UnityEditor.MessageType.Info)]
            public bool _a;
#endif
        }
        [System.Serializable]
        public struct TimersUsoIngles
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("Use: Consists of setting the desired maximum time for the timer or countdown, indicating its visual location, and specifying the methods that will be called when those events are triggered or terminated. This tool provides an efficient way to manage time and maintain control over ongoing processes.", UnityEditor.MessageType.Warning)]
            public bool _a;
#endif
        }
        [System.Serializable]
        public struct TimersAdvertenciaIngles
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("Warning: It is important that each timer is assigned a way to be initialized, the options to assign event reading when activated or deactivated, the different ways to display said timer or other ways to control when to activate or deactivate are optional, it is not need to fill them out.", UnityEditor.MessageType.Error)]
            public bool _a;
#endif
        }
        #endregion

        #endregion

        #region Unlock Content
        [System.Serializable]
        public struct ContentTimers
        {
            [Header("Español:¿Cuántos temporizadores quieres tener?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:How many timers do you want to have?", order = 2)]
            [Space(5, order = 3)]
            public TimersContent[] _timersElements;
        }
        [System.Serializable]
        public struct TimersContent
        {
            [Header("Español:¿Cuál será sera el nombre del elemento?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:What will be the name of the element?", order = 2)]
            [Space(5, order = 3)]
            public string _nameElement;
            [Header("Español:¿Cuál será  la duracion del temporizador?", order = 4)]
            [Space(-10, order = 5)]
            [Header("English:What will be the duration of the timer?", order = 6)]
            [Space(5, order = 7)]
            [Min(0.1f)]
            public float _timerMax;
            [Header("Español:¿De qué  forma se visualizara esta cuenta atras?", order = 8)]
            [Space(-10, order = 9)]
            [Header("English:Will it be displayed with the TMPro interface?", order = 10)]
            [Space(5, order = 11)]
            public VisualEffect _visualEffects;
            [Header("Español:¿Quieres llamar un evento cuando inicie o finalice el timer?", order = 12)]
            [Space(-10, order = 13)]
            [Header("English:Do you want to call an event when the timer starts or ends?", order = 14)]
            [Space(5, order = 15)]
            public Events _unityEvents;
            [Header("Español:¿Como y cuándo  quieres que se inicie/finalice el temporizador?", order = 16)]
            [Space(-10, order = 17)]
            [Header("English:How and when do you want the timer to start or finish?", order = 18)]
            [Space(5, order = 19)]
            public ActivatorsOrDeactivators[] _activatorsOrDeactivators;
            [Header("Español:¿Quieres un temporizador decreciente?", order = 20)]
            [Space(-10, order = 21)]
            [Header("English:Do you want a decreasing timer?", order = 22)]
            [Space(5, order = 23)]
            public bool _isDecrease;
            [Header("Español:¿Quieres que empiece, cuando inicie la escena?", order = 24)]
            [Space(-10, order = 25)]
            [Header("English:Do you want to start, when the scene starts?", order = 26)]
            [Space(5, order = 27)]
            public bool _isBegining;

        }
        [System.Serializable]
        public struct Events
        {
            [Header("Español:¿Cuándo  empiece quieres que lea un metodo?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:When I start do you want me to read a method?", order = 2)]
            [Space(5, order = 3)]
            public UnityEvent _beginigEvent;
            [Header("Español:¿Cuándo finalice quieres que lea un metodo?", order = 4)]
            [Space(-10, order = 5)]
            [Header("English:When I ending, do you want me to read a method?", order = 6)]
            [Space(5, order = 7)]
            public UnityEvent _endingEvent;

        }
        [System.Serializable]
        public struct VisualEffect
        {
            [Header("Español:¿Se visualizara con la interfaz TMPro?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:Will it be displayed with the TMPro interface?", order = 2)]
            [Space(5, order = 3)]
            public TextMeshProUGUI _meshProText;
            [Header("Español:¿Se visualizara con la interfaz Legacy?", order = 4)]
            [Space(-10, order = 5)]
            [Header("English:Will it be displayed with the Legacy interface?", order = 6)]
            [Space(5, order = 7)]
            public Text _legacyText;
            [Header("Español:¿Se visualizara en un Imagen?", order = 8)]
            [Space(-10, order = 9)]
            [Header("English:Will it be displayed in an Image?", order = 10)]
            [Space(5, order = 11)]
            public Image _effectImage;            
            [Header("Español:¿Quieres que cambie de imagen?", order = 12)]
            [Space(-10, order = 13)]
            [Header("English:Do you want me to change my image?", order = 14)]
            [Space(5, order = 15)]
            public Sprite[] _differentsSprites;
            [Header("Español:¿Quieres que la imagen reduzca de tamaño?", order = 16)]
            [Space(-10, order = 17)]
            [Header("English:Do you want the image to reduce in size?", order = 18)]
            [Space(5, order = 19)]
            public bool _efectSmall;
        }

        [System.Serializable]
        public struct ActivatorsOrDeactivators
        {
            [Header("Español:¿Cuál será sera el nombre del elemento?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:What will be the name of the element?", order = 2)]
            [Space(5, order = 3)]
            public string _nameElement;
            [Header("Español:¿Quieres que empiece al pulsar un v?", order = 4)]
            [Space(-10, order = 5)]
            [Header("English:Do you want it to start at the press of a button?", order = 6)]
            [Space(5, order = 7)]
            public Button _buttonElement;
            [Header("Español:¿Quieres que empiece al colisionar  con un objeto 3D?", order = 8)]
            [Space(-10, order = 9)]
            [Header("English:Do you want it to start by colliding with a 3D object?", order = 10)]
            [Space(5, order = 11)]
            public GameObject _trigger3DElement;
            [Header("Español:¿Quieres que empiece al colisionar  con un objeto 2D?", order = 12)]
            [Space(-10, order = 13)]
            [Header("English:Do you want it to start by colliding with a 2D object?", order = 14)]
            [Space(5, order = 15)]
            public GameObject _trigger2DElement;
            [Header("Español:¿Cuál será el comportamiento de estos activadores?", order = 16)]
            [Space(-10, order = 17)]
            [Header("English:What will be the behavior of these triggers?", order = 18)]
            [Space(5, order = 19)]
            public e_Opt9State _stateFunction;
        }
        #endregion

        #region URL Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>        
        public void GetTimersError(int iD)
        {

            string element =  _content._timersElements[iD]._nameElement == "" ? "Timer_" + iD.ToString() : _content._timersElements[iD]._nameElement;

            if ( !_content._timersElements[iD]._visualEffects._effectImage && _content._timersElements[iD]._visualEffects._differentsSprites.Length > 0 || !_content._timersElements[iD]._visualEffects._effectImage && _content._timersElements[iD]._visualEffects._efectSmall)
                Debug.LogWarning($"{SceneManager.GetActiveScene().name}(SC_MenuProPanelesUI)-----> Option 9: Español: Para poder efectuar efectos en la  imagen del {element} <Effect Imagen> ha de estar rellenado \n English: To be able to effect effects on the image in to {element}Effect Image is filled in.");

            if ( !_content._timersElements[iD]._isBegining && _content._timersElements[iD]._activatorsOrDeactivators.Length <= 0)
                Debug.LogWarning($"{SceneManager.GetActiveScene().name}(SC_MenuProPanelesUI)-----> Option 9: Español: Necesitas indicar como quieres iniciar en el {element}\n English: You need to indicate how you want to start in the {element}");

            if ( _content._timersElements[iD]._timerMax <= 0)
                Debug.LogWarning($"{SceneManager.GetActiveScene().name}(SC_MenuProPanelesUI)-----> Option 9: Español: Necesitas indicar un tiempo en el {element}\n English: You need to indicate a time in the {element}");

        }
        #endregion
    }
}
