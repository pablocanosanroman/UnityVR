using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastDoorOpening : MonoBehaviour
{
    [SerializeField] private GameObject m_RightDoor;
    [SerializeField] private GameObject m_LeftDoor;
    [SerializeField] private float m_PositionChangeSpeed;

    public void OpeningDoors()
    {
        Vector3 leftDoorEndPos = new Vector3(12.89f, 2.33f, 4.502f);
        Vector3 rightDoorEndPos = new Vector3(12.89f, 2.33f, -4.525f);

        m_LeftDoor.transform.position = Vector3.Lerp(m_LeftDoor.transform.position, leftDoorEndPos, m_PositionChangeSpeed * Time.deltaTime);
        m_RightDoor.transform.position = Vector3.Lerp(m_RightDoor.transform.position, rightDoorEndPos, m_PositionChangeSpeed * Time.deltaTime);
    }
}
