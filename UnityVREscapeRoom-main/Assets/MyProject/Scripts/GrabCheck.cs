using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.Interaction.Toolkit
{
    public class GrabCheck : MonoBehaviour
    {
        [SerializeField] private GameObject m_ObjectToBeTracked;
        [SerializeField] private XRGrabInteractable m_ObjectGrabbed;
        private Coroutine m_CoroutineHolder;
        private Vector3 m_DefaulPosition;
        private Quaternion m_DefaultRotaton;
        private bool m_HasBeenGrabbed = false;
        private bool m_HasBeenReleased = false;
        private bool m_IsReleased = false;
        private bool m_Dropped = false;

        private void Start()
        {
            m_DefaulPosition = new Vector3(1.175f, 1.121f, -1.228f);
            m_DefaultRotaton = new Quaternion(-5.389f, 180f, 0f, 0f);
            m_CoroutineHolder = null;
        }

        private void Update()
        {
            if(m_ObjectGrabbed.isSelected)
            {
                //Debug.Log("held");
                m_HasBeenGrabbed = true;
                m_IsReleased = false;
            }
            else
            {
                //Debug.Log("not held");
                m_HasBeenReleased = true;
                m_IsReleased = true;
            }

            if(m_HasBeenGrabbed && m_IsReleased && !m_Dropped)
            {
                m_Dropped = true;
                Debug.Log("Dropped");
                m_CoroutineHolder = StartCoroutine(SetToDefaultPosition());
            }

            if (m_HasBeenReleased && m_ObjectGrabbed.isSelected)
            {
                m_Dropped = false;
                Debug.Log("picked up after drop");
                if (m_CoroutineHolder != null)
                {
                    StopCoroutine(m_CoroutineHolder);
                }
                m_HasBeenReleased = false;
            }
        }

        IEnumerator SetToDefaultPosition()
        {
            Debug.Log("teleporting in 5");
            yield return new WaitForSeconds(5f);
            m_ObjectToBeTracked.transform.position = m_DefaulPosition;
            m_ObjectToBeTracked.transform.rotation = m_DefaultRotaton;
            m_Dropped = false;
            Debug.Log("Teleporting happened");
            m_HasBeenGrabbed = false;
        }
    }
}

