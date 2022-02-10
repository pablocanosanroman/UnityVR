using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.Interaction.Toolkit
{
    public class TwoHandGrabInteractable : XRGrabInteractable
    {
        public List<XRSimpleInteractable> secondHandGrabPoints = new List<XRSimpleInteractable>();

        private XRBaseInteractor secondInteractor; //Set on second Attach
        private Quaternion initialSecondAttachRotation; //Required to reset second hand pivot

        private void Start()
        {
            foreach (XRSimpleInteractable interactable in secondHandGrabPoints)
            {
                interactable.onSelectEnter.AddListener(OnSecondHandGrab);
                interactable.onSelectExit.AddListener(OnSecondHandRelease);
            }
        }
        public override bool IsSelectableBy(XRBaseInteractor interactor)
        {
            bool isAlreadyGrabbed = selectingInteractor && !interactor.Equals(selectingInteractor);
            return base.IsSelectableBy(interactor) && !isAlreadyGrabbed;
        }

        private void Update()
        {
            if(secondInteractor != null)
            {
                
            }
        }

        void OnSecondHandGrab(XRBaseInteractor interactor)
        {
            secondInteractor = interactor;
            initialSecondAttachRotation = secondInteractor.transform.localRotation;
            Debug.Log("Second Hand Grabbed!");
        }

        void OnSecondHandRelease(XRBaseInteractor interactor)
        {
            secondInteractor = null;
            initialSecondAttachRotation = Quaternion.identity;
            Debug.Log("Second Hand Released!");
        }
    }
}

