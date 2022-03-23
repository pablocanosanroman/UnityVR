using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketChecker : MonoBehaviour
{
    [SerializeField] private int m_MaxChildSockets;
    private int m_SocketsPlaced = 0;

    [SerializeField] private Animator m_DoorAnimator;
    [SerializeField] private GameObject m_Room3Teleporters;

    public void OnSockedPlaced()
    {
        m_SocketsPlaced++;

        if (m_SocketsPlaced == m_MaxChildSockets)
        {
            m_DoorAnimator.SetTrigger("OpenDoor");
            m_Room3Teleporters.SetActive(true);
        }
    }

    public void OnSocketRemoved()
    {
        
        m_SocketsPlaced--;
    }
}
