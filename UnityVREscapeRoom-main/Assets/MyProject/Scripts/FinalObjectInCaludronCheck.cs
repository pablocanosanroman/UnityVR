using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.Interaction.Toolkit
{
    public class FinalObjectInCaludronCheck : MonoBehaviour
    {
        [SerializeField] private Animator m_DoorAnimator;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("FinalObject"))
            {
                if (!other.gameObject.GetComponent<XRGrabInteractable>().isSelected)
                {
                    other.gameObject.SetActive(false);
                    m_DoorAnimator.SetTrigger("OpenDoor");
                }
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("FinalObject"))
            {
                if (!other.gameObject.GetComponent<XRGrabInteractable>().isSelected)
                {
                    other.gameObject.SetActive(false);
                    m_DoorAnimator.SetTrigger("OpenDoor");
                }
            }
        }
    }
}