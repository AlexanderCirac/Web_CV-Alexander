using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.ToolsInspector;
    using UnityEngine.SceneManagement;
    using AlexanderCA.ProMenu.Enum;

    [System.Serializable]
    public struct PrM_UnlockElementUIInfo
    {
        #region Unlock Explanation

        public ExplicacionUnlockUI _explication;
        public ContentUnlockUI _content;

        [System.Serializable]
        public struct ExplicacionUnlockUI
        {
            public ExplicacionUnlockUIEspañol Español;
            public ExplicacionUnlockUIIngles English;
        }

        #region Spanish
        [System.Serializable]
        public struct ExplicacionUnlockUIEspañol
        {
            public UnlockUIEspañol Explicación;
            public UnlockUIUsoEspañol Uso;
            public UnlockUIAdvertenciaEspañol Advertencia;
        }
        [System.Serializable]
        public struct UnlockUIEspañol
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("En este apartado podrás habilitar o deshabilitar botones, otorgando a cada elemento la opción de bloquear o desbloquearlo según el progreso del jugador o la preferencia del usuario. \n Uso: Es esencial que indiques un ID único para cada elemento . Las demás subsecciones de esta opción son opcionales y son los siguientes, los que te  permitirán personalizar aún más la apariencia  en sus diferentes estados , tambien ofrece formas bascias  de poder bloquear o desloquear, hay mas informacion en el documento, y se proporciona una forma extra de realizar esto, mediante el uso de código.\n Advertencia :Es importante tener en cuenta que debes indicar un ID identificativo único para cada botón y especificar qué botón se utilizará para bloquear/desbloquear, siempre y cuando se aplique en la escena correspondiente. Si no se utiliza en la escena, este parámetro no es necesario completarlo. ¡Ten en cuenta que la asignación del ID es crucial y no puede omitirse!", UnityEditor.MessageType.Info)]
            public bool _a;
#endif
        }

        [System.Serializable]
        public struct UnlockUIUsoEspañol
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("Uso: Es esencial que indiques un ID único para cada elemento . Las demás subsecciones de esta opción son opcionales y son los siguientes, los que te  permitirán personalizar aún más la apariencia  en sus diferentes estados , tambien ofrece formas bascias  de poder bloquear o desloquear, hay mas informacion en el documento, y se proporciona una forma extra de realizar esto, mediante el uso de código.", UnityEditor.MessageType.Warning)]
            public bool _a;
#endif
        }        
        [System.Serializable]
        public struct UnlockUIAdvertenciaEspañol
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("Advertencia :Es importante tener en cuenta que debes indicar un ID identificativo único para cada botón y especificar qué botón se utilizará para bloquear/desbloquear, siempre y cuando se aplique en la escena correspondiente. Si no se utiliza en la escena, este parámetro no es necesario completarlo. ¡Ten en cuenta que la asignación del ID es crucial y no puede omitirse!", UnityEditor.MessageType.Error)]
            public bool _a;
#endif
        }
        #endregion

        #region English
        [System.Serializable]
        public struct ExplicacionUnlockUIIngles
        {
            public UnlockUITotalIngles Explanation;
            public UnlockUIUsoIngles Use;
            public UnlockUIAdvertenciaIngles Warning;
        }
        [System.Serializable]
        public struct UnlockUITotalIngles
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("In this section you can enable or disable buttons, giving each element the option to block or unlock it according to the player's progress or the user's preference. \n Use: It is essential that you provide a unique ID for each element. The other subsections of this option are optional and are the following, which will allow you to further customize the appearance in its different states, it also offers basic ways to lock or unlock, there is more information in the document, and an extra way is provided to do this, by using code.\n Warning :It is important to note that you must provide a unique identifying ID for each button and specify which button will be used to lock/unlock, as long as it is applied in the corresponding scene. If not used in the scene, this parameter does not need to be filled. Please note that the ID assignment is crucial and cannot be omitted!", UnityEditor.MessageType.Info)]
            public bool _a;
#endif
        }
        [System.Serializable]
        public struct UnlockUIUsoIngles
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("Use: It is essential that you provide a unique ID for each element. The other subsections of this option are optional and are the following, which will allow you to further customize the appearance in its different states, it also offers basic ways to lock or unlock, there is more information in the document, and an extra way is provided to do this, by using code.", UnityEditor.MessageType.Warning)]
            public bool _a;
#endif
        }        
        [System.Serializable]
        public struct UnlockUIAdvertenciaIngles
        {
#if UNITY_EDITOR
            [PrM_BoxInspector("Warning :It is important to note that you must provide a unique identifying ID for each button and specify which button will be used to lock/unlock, as long as it is applied in the corresponding scene. If not used in the scene, this parameter does not need to be filled. Please note that the ID assignment is crucial and cannot be omitted!", UnityEditor.MessageType.Error)]
            public bool _a;
#endif
        }
        #endregion

        #endregion

        #region Unlock Content
        [System.Serializable]
        public struct ContentUnlockUI
        {
            [Header("Español:¿Cuántos elementos quieres bloquear o desbloquear?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:How many items do you want to lock or unlock?", order = 2)]
            [Space(5, order = 3)]
            public UnlockUIContent[] _unlockUIElements;
        }
        [System.Serializable]
        public struct UnlockUIContent
        {
            [Header("Español:¿Cuál será el nombre de este elemento?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:What will be the name of this element?", order = 2)]
            [Space(5, order = 3)]
            public string _nameElement;
            [Header("Español:¿La interfaz para Bloquear es un botón?", order = 4)]
            [Space(-10, order = 5)]
            [Header("English:Is the interface for Lock a button?", order = 6)]
            [Space(5, order = 7)]
            public Button _button;
            [Header("Español:¿Cuál será el ID de este elemento?", order = 8)]
            [Space(-10, order = 9)]
            [Header("English:What will be the ID of this element?", order = 10)]
            [Space(5, order = 11)][Min(1)]
            public int _iDElement;
            [Header("Español:¿Este elemento tiene imágenes de bloqueo y desbloqueo?", order = 12)]
            [Space(-10, order = 13)]
            [Header("English:Does this item have lock and unlock images?", order = 14)]
            [Space(5, order = 15)]
            public StateSpriteUnlock _imageStatus;
            [Header("Español:¿De que forma quieres activar/desactivar en este elemento?", order = 16)]
            [Space(-10, order = 17)]
            [Header("English:How do you want to lock/unlock int this element?", order = 18)]
            [Space(5, order = 19)]
            public TriggerToOpt8[] _enabledStatus;
        }
        [System.Serializable]
        public struct StateSpriteUnlock
        {
            [Header("Español:¿Cuál será la imagen para Desbloqueado?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:What will be the image for Unlocked?", order = 2)]
            [Space(5, order = 3)]
            public Sprite _imageUnlock;
            [Header("Español:¿Cuál será la imagen para Bloqueado?", order = 4)]
            [Space(-10, order = 5)]
            [Header("English:What will be the image for Blocked?", order = 6)]
            [Space(5, order = 7)]
            public Sprite _imageLock;
        }
        [System.Serializable]
        public struct TriggerToOpt8
        {
            [Header("Español:¿Cuál será el nombre de este elemento?", order = 0)]
            [Space(-10, order = 1)]
            [Header("English:What will be the name of this element?", order = 2)]
            [Space(5, order = 3)]
            public string _nameElement;
            [Header("Español:¿Cuál ser el comportamiento de estos elementos? ", order = 4)]
            [Space(-10, order = 5)]
            [Header("English:What will be the behavior of these elements?", order = 6)]
            [Space(5, order = 7)]
            public e_Opt8 _state;
            [Header("Español:¿Quieres bloquear/desbloquear mediante un boton?", order = 8)]
            [Space(-10, order = 9)]
            [Header("English:Do you want to lock/unlock using a button?", order = 10)]
            [Space(5, order = 11)]
            public Button _button;
            [Header("Español:¿Quieres bloquear/desbloquear mediante un objeto 3D?", order = 12)]
            [Space(-10, order = 13)]
            [Header("English:Do you want to lock/unlock via a 3D object?", order = 14)]
            [Space(5, order = 15)]
            public GameObject _trigger3D;
            [Header("Español:¿Quieres bloquear/desbloquear mediante un objeto 2D?", order = 16)]
            [Space(-10, order = 17)]
            [Header("English:Do you want to lock/unlock via a 2D object?", order = 18)]
            [Space(5, order = 19)]
            public GameObject _trigger2D;
            [Header("Español:¿Quieres bloquear/desbloquear al terminar la escena?", order = 20)]
            [Space(-10, order = 21)]
            [Header("English:Do you want to lock/unlock at the end of the scene?", order = 22)]
            [Space(5, order = 23)]
            public bool _endScene;
        }
        #endregion

        #region URL Error
        /// <summary>
        /// This is to said when there will be an error
        /// </summary>        
        public void GetUnlockUIError(int iD, int iT = 0, bool _sameID = false)
        {
          
            string element =  _content._unlockUIElements[iD]._nameElement == "" ? "item " + iD.ToString() : _content._unlockUIElements[iD]._nameElement;
            string element2 =  _content._unlockUIElements[iT]._nameElement == "" ? "item " + iT.ToString() : _content._unlockUIElements[iT]._nameElement;

            if ( !_sameID &&_content._unlockUIElements[iD]._iDElement == 0 )
                Debug.LogWarning($"{SceneManager.GetActiveScene().name}(SC_MenuProPanelesUI)-----> Option 8: Español: Te falta añadir la ID del {element} a desbloquear  \n + English:You need to add the ID of the {element} to unlock");

            if ( !_sameID && _content._unlockUIElements[iD]._enabledStatus[iT]._trigger2D != null && _content._unlockUIElements[iD]._enabledStatus[iT]._trigger3D != null )
                Debug.LogWarning($"{SceneManager.GetActiveScene().name } (SC_MenuProPanelesUI)-----> Option 8: Español: No pueden estar los dos elementos activado a la vez en {element}\n English:Both elements cannot be activated at the same time in to {element}");
            if ( _sameID == true)
                Debug.LogWarning($"{SceneManager.GetActiveScene().name } (SC_MenuProPanelesUI)-----> Option 8: Español: El {element} y {element2}  tiene su ID repetida, cambiala por una nueva \n English:Both elements cannot be activated at the same time in to {element} and {element2}");

        }
        #endregion
    }
}
