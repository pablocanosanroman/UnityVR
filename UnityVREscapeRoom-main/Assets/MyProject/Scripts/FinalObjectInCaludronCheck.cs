using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.Interaction.Toolkit
{
    public class FinalObjectInCaludronCheck : MonoBehaviour
    {
        [SerializeField] private Animator m_DoorAnimator;
        [SerializeField] private GameObject m_Room4Objects;
        private AudioManager m_AudioManager;

        private void Start()
        {
            m_AudioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("FinalObject"))
            {
                if (!other.gameObject.GetComponent<XRGrabInteractable>().isSelected)
                {
                    other.gameObject.SetActive(false);
                    m_DoorAnimator.SetTrigger("OpenDoor");
                    m_AudioManager.Play("OpeningDoor");
                    m_Room4Objects.SetActive(true);
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
                    m_Room4Objects.SetActive(true);
                }
            }
        }
    }
}