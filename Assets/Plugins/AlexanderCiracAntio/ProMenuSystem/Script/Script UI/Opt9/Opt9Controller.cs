using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace AlexanderCA.ProMenu.UI
{
    using AlexanderCA.ProMenu.Enum;
    using AlexanderCA.ProMenu.Generic;
    public class Opt9Controller : MonoBehaviour
    {
        #region Attributes
        public UnityAction<int,e_Opt9,e_Opt9State> OnActivatio;
        public static Opt9Controller Instance
        {
            get
            {        
                return SingletonGeneric<Opt9Controller>.Instance;
            }
        }
        #endregion
    }
}
