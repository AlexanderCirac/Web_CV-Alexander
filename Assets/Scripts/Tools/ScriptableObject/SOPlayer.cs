    using System.Collections;
    using System.Collections.Generic;

namespace WebGame.Game.ScriptableObject
{
    using UnityEngine;
    [CreateAssetMenu(fileName ="PlayerSO")]
    public class SOPlayer : ScriptableObject
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

}