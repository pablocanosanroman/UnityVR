using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleSysem : MonoBehaviour
{
    public int m_GoalCount = 0;
    [SerializeField] private GameObject m_LastDoorButton;

    private void Update()
    {
        if(m_GoalCount >= 3)
        {
            m_GoalCount = 3;
            m_LastDoorButton.SetActive(true);

        }
    }
}
