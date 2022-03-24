using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBulletInteraction : MonoBehaviour
{
    [SerializeField] private HoleSysem m_HoleSystem;
    private List<Collider> m_Colliders;

    private void Start()
    {
        m_Colliders = new List<Collider>();
        m_Colliders.AddRange(gameObject.GetComponents<BoxCollider>());
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            m_HoleSystem.m_GoalCount++;
            Debug.Log("ShouldGoUp");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Bullet"))
        {
            foreach(Collider boxCollider in m_Colliders)
            {
                boxCollider.enabled = false;
                Debug.Log("ShouldDisableColliders");
            }
        }

    }
}
