using UnityEngine;

namespace WebGame.Game.Character
{
    using WebGame.Game.Templates;
    public class PlayerCharacter : CharacterTemplate
    {
        #region Abstract customs methods
        protected override void ToMovement()
        {
            float _moveSpeed = Input.GetKey(KeyCode.LeftShift) ? 10 * Time.deltaTime : 5 * Time.deltaTime;
            this.transform.Translate(Vector3.forward * _inputs.GetHorizontal() * _moveSpeed);
            this.transform.Translate(Vector3.right * _inputs.GetVertical() * _moveSpeed);
        }
        protected override void ToJumping()
        {
            float _jumpSpeed = 300 * Time.deltaTime;
            GetComponent<Rigidbody>().velocity = ( Vector3.up * _jumpSpeed );
        }
        protected override void ToRotate()
        {
            return;
        }
        #endregion
    }
}
