using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButton : MonoBehaviour
{
    public GameObject m_BlueLight;
    public bool m_BlueButtonPressed;

    public delegate void OnButtonPressed(BlueButton ptr);
    public event OnButtonPressed onButtonPressed;

    public void OnInteractablePressed()
    {
        onButtonPressed.Invoke(this);

        m_BlueButtonPressed = true;
        m_BlueLight.SetActive(true);
    }
        
}

