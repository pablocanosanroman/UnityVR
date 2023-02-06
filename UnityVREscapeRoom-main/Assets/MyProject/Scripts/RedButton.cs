using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public GameObject m_RedLight;
    public bool m_RedButtonPressed;

    public delegate void OnButtonPressed(RedButton ptr);
    public event OnButtonPressed onButtonPressed;

    public void OnInteractablePressed()
    {
        onButtonPressed.Invoke(this);
        m_RedLight.SetActive(true);
        m_RedButtonPressed = true;
    }
}
