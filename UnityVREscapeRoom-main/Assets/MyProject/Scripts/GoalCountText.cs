using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class GoalCountText : MonoBehaviour
{
    [SerializeField] private TMPro.TextMeshPro m_GoalCountText;
    [SerializeField] private HoleSysem m_HoleSystem;

    private void Update()
    {
        m_GoalCountText.text = m_HoleSystem.m_GoalCount.ToString();
    }
}
