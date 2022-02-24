using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TextDisappear : MonoBehaviour
{
    private float m_TextLifeTime = 5f;
    [SerializeField] private GameObject m_TextObject;

    
    private void Update()
    {
        if(m_TextObject.GetComponent<Renderer>().isVisible)
        {
            StartCoroutine(TextDestroy());
        }
    }

    IEnumerator TextDestroy()
    {
        yield return new WaitForSeconds(m_TextLifeTime);
        Destroy(gameObject);
    }
}
