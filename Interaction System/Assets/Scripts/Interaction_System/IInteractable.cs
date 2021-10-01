using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eswaregames
{
    public interface IInteractable 
    {
        public void OnInteract();

        public void Pick();

        public void Release();

    }
}

