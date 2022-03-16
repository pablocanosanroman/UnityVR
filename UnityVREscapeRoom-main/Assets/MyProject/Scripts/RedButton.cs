using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public GameObject m_RedLight;
    public bool m_RedButtonPressed;

    public void OnInteractablePressed()
    {
        m_RedLight.SetActive(true);
        m_RedButtonPressed = true;
    }
}
