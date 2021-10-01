using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace eswaregames
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraInputData cameraInputData = null;
        [SerializeField] private float mouseSensitivity = 100f;
        [SerializeField] private Transform playerBody= null;

        private float xRotation = 0f;

        private void Awake()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void LateUpdate()
        {
            float mouseX = cameraInputData.MouseX * Time.deltaTime * mouseSensitivity;
            float mouseY = cameraInputData.MouseY * Time.deltaTime * mouseSensitivity;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);

        }
    }
}

