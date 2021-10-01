using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace eswaregames
{
    [CreateAssetMenu(fileName ="CameraInputData",menuName ="EswareGames/CharacterController/Data/CameraInputData")]
    public class CameraInputData : ScriptableObject
    {
        private float mouseX;
        private float mouseY;

        public float MouseX
        {
            get => mouseX;
            set => mouseX = value;
        }

        public float MouseY
        {
            get => mouseY;
            set => mouseY = value;
        }
    }

}


