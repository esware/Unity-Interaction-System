using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eswaregames
{
    public class DestroyInteractable : InteractableBase
    {
        private void Update()
        {
            GetOutline.SetOutlineDisable();
        }
        public override void OnInteract()
        {
            base.OnInteract();
            Destroy(gameObject);
        }

        public override void Pick()
        {
            base.Pick();
        }

        public override void Release()
        {
            base.Release();
        }
    }
}
