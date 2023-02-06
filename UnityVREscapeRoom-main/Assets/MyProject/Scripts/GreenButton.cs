using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour
{
    public GameObject m_GreenLight;
    public bool m_GreenButtonPressed;

    public delegate void OnButtonPressed(GreenButton ptr);
    public event OnButtonPressed onButtonPressed;

    public void OnInteractablePressed()
    {
        onButtonPressed.Invoke(this);
        m_GreenLight.SetActive(true);
        m_GreenButtonPressed = true;
    }
}
