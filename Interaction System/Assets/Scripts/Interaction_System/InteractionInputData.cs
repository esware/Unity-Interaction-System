using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eswaregames
{
    [CreateAssetMenu(fileName ="InteractionIpnutData",menuName ="EswareGames/InteractionSystem/Data/InteractionInputData")]
    public class InteractionInputData : ScriptableObject
    {
        private bool interactedClicked;
        private bool interactedReleased;
        private bool isRelease;
        private bool rotateX;
        private bool rotateY;
        private bool rotateZ;


        public bool InteractedClicked { get => interactedClicked; set => interactedClicked = value; }
        public bool InteractedReleased { get => interactedReleased; set => interactedReleased = value; }
        public bool IsRelease { get => isRelease; set => isRelease = value; }
        public bool RotateX { get => rotateX; set => rotateX = value; }
        public bool RotateY { get => rotateY; set => rotateY = value; }
        public bool RotateZ { get => rotateZ; set => rotateZ = value; }
    }
}

