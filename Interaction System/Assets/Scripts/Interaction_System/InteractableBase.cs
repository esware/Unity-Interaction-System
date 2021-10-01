using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

namespace eswaregames
{
    public class InteractableBase : MonoBehaviour, IInteractable
    {
        [Space,Header("Interactable Settings")]

        [SerializeField] private bool holdInteract;
        [ShowIf("holdInteract")]
        [SerializeField] private float holdDuration;
        [SerializeField] private bool isPickable;
        [ShowIf("isPickable")] [SerializeField] private string rotateMessage = "";
        [Space]
        [SerializeField] private string tooltipMessage = "Interact";
        [SerializeField] private Outline outline = null;



        public Outline GetOutline { get => outline; set => outline = value; }

        public string RotateMessage => rotateMessage;
        public bool IsPickable => isPickable;
        public bool HoldInteract => holdInteract;
        public float HoldDuration => holdDuration;
        public string TooltipMessage => tooltipMessage;

        private void Awake()
        {
            outline = GetComponent<Outline>();
        }

        public virtual void OnInteract()
        {
            
        }

        public virtual void Pick()
        {
            
        }

        public virtual void Release()
        {
            
        }

        public virtual void Rotate()
        {

        }

    }
}

