using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour
{
    public GameObject m_GreenLight;
    public bool m_GreenButtonPressed;

    public void OnInteractablePressed()
    {
        m_GreenLight.SetActive(true);
        m_GreenButtonPressed = true;
    }
}
