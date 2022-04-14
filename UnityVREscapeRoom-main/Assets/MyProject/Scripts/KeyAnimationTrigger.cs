using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.Interaction.Toolkit
{
    public class KeyAnimationTrigger : MonoBehaviour
    {
        [SerializeField] private GameObject m_Key;
        //[SerializeField] private Transform m_AttachPoint;
        [SerializeField] private Animator m_DoorAnimator;
        [SerializeField] private Animator m_KeyAnimator;
        [SerializeField] private GameObject m_Room2;
        private AudioManager m_AudioManager;
        //[SerializeField] private MeshCollider m_KeyMesh;
        //private bool m_IsReleased = false;
        //private bool m_HasBeenGrabbed = false;
        //private bool m_InRangeOfTriggerAnimation = false;

        private void Start()
        {
            m_AudioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();    
        }

        public void OnSocketPlaced()
        {
            if (m_Key != null)
            {
                m_KeyAnimator.enabled = true;
                m_KeyAnimator.SetTrigger("KeyRotation");
                m_Room2.SetActive(true);
                StartCoroutine(WaitForKeyToOpen());
                //m_HasBeenGrabbed = false;
                
            }
        }
        //Make the key teleport to the desire position in the keyhole then fire the animation
        private void Update()
        {
            //if (m_Key.GetComponent<XRGrabInteractable>().isSelected)
            //{
            //    //Debug.Log("held");
            //    m_HasBeenGrabbed = true;
            //    m_IsReleased = false;
            //}
            //else
            //{
            //    //Debug.Log("not held");
            //    m_IsReleased = true;
            //}
            //if(m_Key != null)
            //{
            //    if (m_Key.GetComponent<XRGrabInteractable>().isSelected)
            //    {
            //        //Debug.Log("held");
            //        m_HasBeenGrabbed = true;
            //        m_IsReleased = false;
            //    }
            //    else
            //    {
            //        //Debug.Log("not held");
            //        m_IsReleased = true;
            //    }

            //    if (m_HasBeenGrabbed && m_IsReleased && m_InRangeOfTriggerAnimation)
            //    {
            //        m_Key.transform.position = m_AttachPoint.position;
            //        m_Key.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;
            //        m_Key.GetComponent<Rigidbody>().useGravity = false;
            //        m_KeyMesh.enabled = false;
            //        m_KeyAnimator.enabled = true;
            //        m_KeyAnimator.SetTrigger("KeyRotation");
            //        StartCoroutine(WaitForKeyToOpen());
            //        m_HasBeenGrabbed = false;
            //    }
            //}

        }
        //private void OnTriggerEnter(Collider other)
        //{
        //    m_InRangeOfTriggerAnimation = true;
        //}
        //private void OnTriggerExit(Collider other)
        //{
        //    m_InRangeOfTriggerAnimation = false;
        //}

        IEnumerator WaitForKeyToOpen()
        {
            yield return new WaitForSeconds(0.7f);
            m_DoorAnimator.SetTrigger("OpenDoor");
            m_AudioManager.Play("OpeningDoor");

        }
    }
}
