using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoAnimationTrigger : MonoBehaviour
{
    [SerializeField] private Animator m_DominoAnimator;
    public bool m_AnimationTriggered = false;

    private void OnCollisionEnter(Collision collision)
    {
        m_DominoAnimator.SetTrigger("DominoEffect");
        m_AnimationTriggered = true;
    }
}
