using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eswaregames
{
    [CreateAssetMenu(fileName ="MovementInputData",menuName ="EswareGames/CharacterController/Data/MovementInputData")]
    public class MovementInputData : ScriptableObject
    {
        private float horizontal;
        private float vertical;
        private bool isJump;


        public bool IsJump
        {
            get => isJump;
            set => isJump = value;
        }


        public float Horizontal
        {
            get => horizontal;
            set => horizontal = value;
        }

        public float Vertical
        {
            get => vertical;
            set => vertical = value;
        }
    }

}
