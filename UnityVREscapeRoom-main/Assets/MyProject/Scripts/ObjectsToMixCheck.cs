using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.Interaction.Toolkit
{
    public class ObjectsToMixCheck : MonoBehaviour
    {
        [SerializeField] private GameObject m_FinalObjectMade;
        private List<GameObject> m_ObjectsToMix;

        private void Start()
        {
            m_ObjectsToMix = new List<GameObject>();
        }

        private void Update()
        {
            if (m_ObjectsToMix.Count == 3)
            {
                m_FinalObjectMade.SetActive(true);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("ObjectsToMix"))
            {
                if(!other.gameObject.GetComponent<XRGrabInteractable>().isSelected)
                {
                    if (!m_ObjectsToMix.Contains(other.gameObject))
                    {
                        m_ObjectsToMix.Add(other.gameObject);
                        other.gameObject.SetActive(false);
                    }
                }
                
            }
            else if(other.gameObject.CompareTag("ObjectsToNotMix"))
            {
                if (!other.gameObject.GetComponent<XRGrabInteractable>().isSelected)
                {
                    other.gameObject.SetActive(false);
                }
            }
        }

        private void OnTriggerStay(Collider other)
        {
            
            if (other.gameObject.CompareTag("ObjectsToMix"))
            {
                if(!other.gameObject.GetComponent<XRGrabInteractable>().isSelected)
                {
                    if (!m_ObjectsToMix.Contains(other.gameObject))
                    {
                        m_ObjectsToMix.Add(other.gameObject);
                        other.gameObject.SetActive(false);
                    }
                }
                
            }
            else if(other.gameObject.CompareTag("ObjectsToNotMix"))
            {
                if (!other.gameObject.GetComponent<XRGrabInteractable>().isSelected)
                {
                    other.gameObject.SetActive(false);
                }
            }
            
            
        }
    }
}

