using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.Interaction.Toolkit
{
    public class KeyAnimationTrigger : MonoBehaviour
    {
        [SerializeField] private GameObject m_Key;
        [SerializeField] private Animator m_DoorAnimator;
        [SerializeField] private Animator m_KeyAnimator;
        private bool m_IsReleased = false;
        private bool m_HasBeenGrabbed = false;
        private bool m_InRangeOfTriggerAnimation = false;

        //Make the key teleport to the desire position in the keyhole then fire the animation
        private void Update()
        {
            if(m_Key != null)
            {
                if (m_Key.GetComponent<XRGrabInteractable>().isSelected)
                {
                    //Debug.Log("held");
                    m_HasBeenGrabbed = true;
                    m_IsReleased = false;
                }
                else
                {
                    //Debug.Log("not held");
                    m_IsReleased = true;
                }

                if (m_HasBeenGrabbed && m_IsReleased && m_InRangeOfTriggerAnimation)
                {
                    Destroy(m_Key);
                    StartCoroutine(WaitForKeyToOpen());
                    m_HasBeenGrabbed = false;
                }
            }
            
        }
        private void OnTriggerEnter(Collider other)
        {
            m_InRangeOfTriggerAnimation = true;
        }
        private void OnTriggerExit(Collider other)
        {
            m_InRangeOfTriggerAnimation = false;
        }

        IEnumerator WaitForKeyToOpen()
        {
            yield return new WaitForSeconds(0.7f);

            m_DoorAnimator.SetTrigger("KeyAnimCompleted");

        }
    }
}
