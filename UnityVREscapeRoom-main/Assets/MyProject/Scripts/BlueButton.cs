using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour
{
    public GameObject m_BlueLight;
    public bool m_BlueButtonPressed;

    public void OnInteractablePressed()
    {
        m_BlueButtonPressed = true;
        m_BlueLight.SetActive(true);
    }
        
}

