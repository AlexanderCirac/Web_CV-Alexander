using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [SerializeField]
    public class PlayerSOZenject
    {
        #region Attributes
        [Header("Variable of Movement")]
        [Min(1)]
        public float _jumpsSpeed;
        [Min(1)]
        public float _rotateSpeed;
        [Min(1)]
        public float _movementSpeed;
        [Header("Key Controller")]
        public KeyCode _keyLeft;
        public KeyCode _keyRight;
        public KeyCode _keyFrontOf;
        public KeyCode _keyBack;
        public KeyCode _keyJump;
  
    #endregion
}

