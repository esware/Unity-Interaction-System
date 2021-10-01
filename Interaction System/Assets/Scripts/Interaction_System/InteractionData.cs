using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eswaregames
{
    [CreateAssetMenu(fileName ="InteractionData",menuName ="EswareGames/InteractionSystem/Data/InteractionData")]
    public class InteractionData : ScriptableObject
    {
        [SerializeField] 
        private InteractableBase interactable;

        public InteractableBase Interactable { get => interactable; set => interactable = value; }


        public void Interact()
        {
            interactable.OnInteract();
        }

        public void Pick()
        {
            interactable.Pick();
        }

        public void Release()
        {
            interactable.Release();
        }

        public bool IsSameInteractable(InteractableBase _interactable) => interactable == _interactable;
        public bool IsEmpty() => interactable == null;
        public void ResetData() => interactable = null;
    }

}
