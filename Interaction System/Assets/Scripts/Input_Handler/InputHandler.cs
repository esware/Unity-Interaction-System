using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eswaregames
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] private CameraInputData cameraInputData = null;
        [SerializeField] private MovementInputData movementInputData = null;
        [SerializeField] private InteractionInputData interactionInputData = null;


        private void Update()
        {
            GetCameraInput();
            GetMovementInput();
            GetInteractionInput();
        }

        void GetMovementInput()
        {
            movementInputData.Horizontal = Input.GetAxis("Horizontal");
            movementInputData.Vertical = Input.GetAxis("Vertical");
            movementInputData.IsJump = Input.GetKeyDown(KeyCode.Space);
        }

        void GetCameraInput()
        {
            cameraInputData.MouseX = Input.GetAxis("Mouse X");
            cameraInputData.MouseY = Input.GetAxis("Mouse Y");
        }

        void GetInteractionInput()
        {
            interactionInputData.InteractedClicked = Input.GetKeyDown(KeyCode.E);
            interactionInputData.InteractedReleased = Input.GetKeyUp(KeyCode.E);
            interactionInputData.RotateX = Input.GetKeyDown(KeyCode.Alpha1);
            interactionInputData.RotateY = Input.GetKeyDown(KeyCode.Alpha2);
            interactionInputData.RotateZ = Input.GetKeyDown(KeyCode.Alpha3);
        }
    }
}

