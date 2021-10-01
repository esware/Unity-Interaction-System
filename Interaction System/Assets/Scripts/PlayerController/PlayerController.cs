using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eswaregames
{
    public class PlayerController : MonoBehaviour
    {
        #region Data
        [SerializeField] private MovementInputData movementInputData = null;
        [SerializeField] private CharacterController controller = null;
        [SerializeField] private float speed = 5f;
        [SerializeField] private float gravity = -9.81f;
        [SerializeField] private Transform groundcheck = null;
        [SerializeField] private float groundDistance = 0.3f;
        [SerializeField] private LayerMask groundMask;
        [SerializeField] private float jumpHeight = 3f;
        #endregion

        Vector3 velocity;
        bool isGrounded;

        #region Methods

        private void Update()
        {
            isGrounded = Physics.CheckSphere(groundcheck.position, groundDistance, groundMask);
            if(isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            if(movementInputData.IsJump && isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }

            Vector3 move = transform.right * movementInputData.Horizontal + transform.forward * movementInputData.Vertical;
            controller.Move(move*speed*Time.deltaTime);

            velocity.y += gravity *3.4f* Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
        #endregion
    }
}

