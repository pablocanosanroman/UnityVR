using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastDoorOpening : MonoBehaviour
{
    [SerializeField] private Animator m_LastDoor;
    [SerializeField] private float m_PositionChangeSpeed;

    public void OpeningDoors()
    {
        m_LastDoor.SetTrigger("OpeningLastDoor");
        SceneManager.LoadScene("WinScreen");
    }
}
