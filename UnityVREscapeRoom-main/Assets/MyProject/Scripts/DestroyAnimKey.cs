using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DestroyAnimKey : MonoBehaviour
{

    public void Destroy()
    {
        gameObject.SetActive(false);
        Debug.Log("Should Disappear");
    }
}
