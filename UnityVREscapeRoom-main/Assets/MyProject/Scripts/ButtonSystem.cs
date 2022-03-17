using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSystem : MonoBehaviour
{
    private List<GameObject> m_Buttons;
    [SerializeField] private BlueButton m_BlueButton;
    [SerializeField] private GreenButton m_GreenButton;
    [SerializeField] private RedButton m_RedButton;
    [SerializeField] private GameObject m_SocketPilarOne;
    [SerializeField] private GameObject m_SocketPilarTwo;
    [SerializeField] private GameObject m_Spheres;
    private bool m_AllButtonsPressed;

    private void Start()
    {
        m_Buttons = new List<GameObject>();
        m_BlueButton.onButtonPressed += OnBlueButtonPressed;
        m_GreenButton.onButtonPressed += OnGreenButtonPressed;
        m_RedButton.onButtonPressed += OnRedButtonPressed;
    }

    private void OnBlueButtonPressed(BlueButton ptr)
    {
        if(!m_Buttons.Contains(ptr.gameObject))
        {
            m_Buttons.Add(ptr.gameObject);
        }

        CheckList();
    }
    private void OnGreenButtonPressed(GreenButton ptr)
    {
        if (!m_Buttons.Contains(ptr.gameObject))
        {
            m_Buttons.Add(ptr.gameObject);
        }

        CheckList();
    }
    private void OnRedButtonPressed(RedButton ptr)
    {
        if (!m_Buttons.Contains(ptr.gameObject))
        {
            m_Buttons.Add(ptr.gameObject);
        }

        CheckList();
    }

    private void CheckList()
    {
        if (m_Buttons.Count < 3) return ;

        
        m_AllButtonsPressed = true;
        if (m_AllButtonsPressed)
        {
            if (m_BlueButton != m_Buttons[0] || m_GreenButton != m_Buttons[1] || m_RedButton != m_Buttons[2])
            {
                m_AllButtonsPressed = false;
                m_BlueButton.m_BlueButtonPressed = false;
                m_BlueButton.m_BlueLight.SetActive(false);

                m_RedButton.m_RedButtonPressed = false;
                m_RedButton.m_RedLight.SetActive(false);

                m_GreenButton.GetComponent<GreenButton>().m_GreenButtonPressed = false;
                m_GreenButton.GetComponent<GreenButton>().m_GreenLight.SetActive(false);

                m_Buttons.Remove(m_BlueButton.gameObject);
                m_Buttons.Remove(m_RedButton.gameObject);
                m_Buttons.Remove(m_GreenButton.gameObject);
            }
            else
            {
                m_SocketPilarOne.SetActive(true);
                m_SocketPilarTwo.SetActive(true);
            }
        }
        

    }

    private void Update()
    {
        //if(m_BlueButton.GetComponent<BlueButton>().m_BlueButtonPressed)
        //{
        //    if(!m_Buttons.Contains(m_BlueButton))
        //    {
        //        m_Buttons.Add(m_BlueButton);
        //    }
        //}
        
        //if(m_RedButton.GetComponent<RedButton>().m_RedButtonPressed)
        //{
        //    if(!m_Buttons.Contains(m_RedButton))
        //    {
        //        m_Buttons.Add(m_RedButton);
        //    }
        //}
        
        //if(m_GreenButton.GetComponent<GreenButton>().m_GreenButtonPressed)
        //{
        //    if(!m_Buttons.Contains(m_GreenButton))
        //    {
        //        m_Buttons.Add(m_GreenButton);
        //    }
            
        //}

       
    }
}
