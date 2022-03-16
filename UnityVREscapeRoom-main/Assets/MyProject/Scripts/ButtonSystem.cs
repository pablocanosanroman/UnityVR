using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSystem : MonoBehaviour
{
    private List<GameObject> m_Buttons;
    [SerializeField] private GameObject m_BlueButton;
    [SerializeField] private GameObject m_GreenButton;
    [SerializeField] private GameObject m_RedButton;
    [SerializeField] private GameObject m_SocketPilarOne;
    [SerializeField] private GameObject m_SocketPilarTwo;
    private bool m_AllButtonsPressed;

    private void Start()
    {
        m_Buttons = new List<GameObject>();
    }

    private void Update()
    {
        if(m_BlueButton.GetComponent<BlueButton>().m_BlueButtonPressed)
        {
            if(!m_Buttons.Contains(m_BlueButton))
            {
                m_Buttons.Add(m_BlueButton);
            }
        }
        
        if(m_RedButton.GetComponent<RedButton>().m_RedButtonPressed)
        {
            if(!m_Buttons.Contains(m_RedButton))
            {
                m_Buttons.Add(m_RedButton);
            }
        }
        
        if(m_GreenButton.GetComponent<GreenButton>().m_GreenButtonPressed)
        {
            if(!m_Buttons.Contains(m_GreenButton))
            {
                m_Buttons.Add(m_GreenButton);
            }
            
        }

        if(m_BlueButton.GetComponent<BlueButton>().m_BlueButtonPressed && m_RedButton.GetComponent<RedButton>().m_RedButtonPressed && 
            m_GreenButton.GetComponent<GreenButton>().m_GreenButtonPressed)
        {
            m_AllButtonsPressed = true;
            if(m_AllButtonsPressed)
            {
                if(m_BlueButton != m_Buttons[0] || m_GreenButton != m_Buttons[1] || m_RedButton != m_Buttons[2])
                {
                    m_AllButtonsPressed = false;
                    m_BlueButton.GetComponent<BlueButton>().m_BlueButtonPressed = false;
                    m_BlueButton.GetComponent<BlueButton>().m_BlueLight.SetActive(false);

                    m_RedButton.GetComponent<RedButton>().m_RedButtonPressed = false;
                    m_RedButton.GetComponent<RedButton>().m_RedLight.SetActive(false);

                    m_GreenButton.GetComponent<GreenButton>().m_GreenButtonPressed = false;
                    m_GreenButton.GetComponent<GreenButton>().m_GreenLight.SetActive(false);

                    m_Buttons.Remove(m_BlueButton);
                    m_Buttons.Remove(m_RedButton);
                    m_Buttons.Remove(m_GreenButton);
                }
                else
                {
                    m_SocketPilarOne.SetActive(true);
                    m_SocketPilarTwo.SetActive(true);
                }
            }
        }
    }
}
