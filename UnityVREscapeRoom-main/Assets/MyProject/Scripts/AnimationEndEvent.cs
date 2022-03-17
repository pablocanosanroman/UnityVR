using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEndEvent : MonoBehaviour
{
    [SerializeField] private float m_PositionChangeSpeed;
    [SerializeField] private DominoAnimationTrigger m_DominoAnimation;
    [SerializeField] private GameObject m_Key;
    [SerializeField] private GameObject m_Room2Teleporters;
    private void Update()
    {
        if(m_DominoAnimation.m_AnimationTriggered)
        {
            StartCoroutine(WaitForTheAnimationToEnd());
        }
    }
    
    IEnumerator WaitForTheAnimationToEnd()
    {
        yield return new WaitForSeconds(5.5f);
        m_Key.SetActive(true);
        Vector3 endPos = new Vector3(0f, 0.7f, 0f);
        transform.position = Vector3.Lerp(transform.position, endPos, m_PositionChangeSpeed * Time.deltaTime);
        m_Room2Teleporters.SetActive(true);
        m_DominoAnimation.m_AnimationTriggered = false;
    }
}
