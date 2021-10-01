using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace eswaregames
{
    public class InteractionController : MonoBehaviour
    {
        [SerializeField] private InteractionInputData interactionInputData = null;
        [SerializeField] private InteractionData interactionData = null;
        [SerializeField] private InteractionUIPanel uiPanel = null;

        [SerializeField] private float rayRadius = 0.1f;
        [SerializeField] private float rayDistance = 4f;
        [SerializeField] private LayerMask interactableLayer;



        private Camera cam;
        private bool _interacting;
        private bool _picking;
        private int pickCounter = 0;
        private float holdTimer = 0f;

        private void Awake()
        {
            cam = FindObjectOfType<Camera>();
        }

        private void Update()
        {
            CheckForInteractable();
            CheckForInteractableInput();
        }

        void CheckForInteractable()
        {
            Ray _ray = new Ray(cam.transform.position, cam.transform.forward);
            RaycastHit hitInfo;
            bool hitSomething = Physics.SphereCast(_ray, rayRadius,out hitInfo, rayDistance, interactableLayer);

            if (hitSomething)
            {
                InteractableBase _interactable = hitInfo.transform.GetComponent<InteractableBase>();
                Outline _outline = hitInfo.transform.GetComponent<Outline>();
                _outline.SetOutlineActive();

                if (_interactable != null)
                {
                    if (interactionData.IsEmpty())
                    {
                        interactionData.Interactable = _interactable;
                        uiPanel.SetTooltip(_interactable.TooltipMessage);
                    }
                    else
                    {
                        if (!interactionData.IsSameInteractable(_interactable))
                        {
                            interactionData.Interactable = _interactable;
                            uiPanel.SetTooltip(_interactable.TooltipMessage);
                        }
                    }
                }
            }
            else
            {
                uiPanel.ResetUI();
                interactionData.ResetData();
            }
            Debug.DrawRay(_ray.origin, _ray.direction*rayDistance, hitSomething ? Color.green : Color.red);
        }

        void CheckForInteractableInput()
        {
            if (interactionData.IsEmpty())
                return;

            if (interactionInputData.InteractedClicked)
            {
                if (!interactionData.Interactable.IsPickable)
                {
                    _interacting = true;
                    holdTimer = 0f;
                }
                else
                {
                    _picking = true;
                }
            }

            if (interactionInputData.InteractedReleased)
            {
                _interacting = false;
                holdTimer = 0f;
                uiPanel.UpdateProgressBar(0f);

                if (interactionData.Interactable.IsPickable)
                {
                    if (interactionData.Interactable.HoldInteract)
                    {
                        _picking = false;
                        holdTimer = 0f;
                        uiPanel.UpdateProgressBar(0f);
                    }
                }
            }

            if (_picking && pickCounter == 0)
            {
                if (interactionData.Interactable.HoldInteract)
                {
                    holdTimer += Time.deltaTime;
                    float heldPercent = holdTimer / interactionData.Interactable.HoldDuration;
                    uiPanel.UpdateProgressBar(heldPercent);


                    if (heldPercent > 1f)
                    {
                        interactionData.Pick();
                        _picking = false;
                        pickCounter += 1;
                        uiPanel.SetTooltip(interactionData.Interactable.RotateMessage);
                    }

                    if(pickCounter ==1 && _picking)
                    {
                        _picking = false;
                        pickCounter = 0;
                        uiPanel.ResetUI();
                    }
                }
                else
                {
                    interactionData.Pick();
                    _picking = false;
                    pickCounter +=1;
                    uiPanel.SetTooltip(interactionData.Interactable.RotateMessage);
                }
            }

            if(pickCounter ==1 && _picking)
            {
                interactionData.Release();
                _picking = false;
                pickCounter = 0;
                uiPanel.ResetUI();
            }

            if (_interacting)
            {
                if (interactionData.Interactable.HoldInteract)
                {
                    holdTimer += Time.deltaTime;
                    float heldPercent = holdTimer / interactionData.Interactable.HoldDuration;
                    uiPanel.UpdateProgressBar(heldPercent);


                    if (heldPercent > 1f)
                    {
                        interactionData.Interact();
                        _interacting = false;
                    }
                }
                else
                {
                    interactionData.Interact();
                    _interacting = false;
                }
            }
        }
    }
}

