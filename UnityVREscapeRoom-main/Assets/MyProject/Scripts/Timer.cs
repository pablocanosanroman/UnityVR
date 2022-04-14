using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float m_TimeRemaining;
    private float m_Minutes;
    private float m_Seconds;
    [SerializeField] private TMPro.TextMeshPro m_Timer;

    private void Update()
    {
        
        if(m_TimeRemaining > 0)
        {
            m_TimeRemaining -= Time.deltaTime;
        }
        else
        {
            m_TimeRemaining = 0;
            SceneManager.LoadScene("LossScreen", LoadSceneMode.Single);
        }

        m_Minutes = Mathf.FloorToInt(m_TimeRemaining / 60);
        m_Seconds = Mathf.FloorToInt(m_TimeRemaining % 60);

        m_Timer.text = m_Minutes.ToString() + ":" + m_Seconds.ToString();
    }
}
