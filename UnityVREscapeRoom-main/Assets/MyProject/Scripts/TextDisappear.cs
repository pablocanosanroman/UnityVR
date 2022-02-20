using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisappear : MonoBehaviour
{
    private float m_TextLifeTime = 5f;
    void Start()
    {
        StartCoroutine(TextDestroy());
    }

    IEnumerator TextDestroy()
    {
        yield return new WaitForSeconds(m_TextLifeTime);
        Destroy(gameObject);
    }
}
