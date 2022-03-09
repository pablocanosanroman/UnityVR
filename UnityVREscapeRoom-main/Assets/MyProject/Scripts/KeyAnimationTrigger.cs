using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.Interaction.Toolkit
{
    public class KeyAnimationTrigger : MonoBehaviour
    {
        [SerializeField] private GameObject m_Key;
        [SerializeField] private GameObject m_AnimKey;
        private GameObject[] m_Hands;
        private List<GameObject> m_HandsList;
        [SerializeField] private Animator m_DoorAnimator;

        private void Start()
        {
            m_HandsList = new List<GameObject>();
        }

        private void Update()
        {
            m_Hands = GameObject.FindGameObjectsWithTag("Hand");
            m_HandsList.AddRange(m_Hands);
        }
        private void OnTriggerEnter(Collider other)
        {
            Destroy(m_Key);
            foreach(GameObject hand in m_HandsList)
            {
                hand.SetActive(true);
            }
            m_AnimKey.SetActive(true);
            StartCoroutine(WaitForKeyToOpen());
        }

        IEnumerator WaitForKeyToOpen()
        {
            yield return new WaitForSeconds(1.0f);

            m_DoorAnimator.SetTrigger("KeyAnimCompleted");

        }
    }
}
