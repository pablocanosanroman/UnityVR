using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFire : MonoBehaviour
{
    [SerializeField] private GameObject m_BulletPref;
    [SerializeField] private float m_BulletSpeed;
    private AudioManager m_AudioManager;
    private GameObject m_BulletHolder;
    private float m_BulletLifeTime = 3f;
    private bool m_CanShoot = true;

    private void Start()
    {
        m_AudioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();    
    }

    public void OnActivated()
    {
        if(m_CanShoot)
        {
            m_AudioManager.Play("GunFire");
            m_BulletHolder = Instantiate(m_BulletPref, transform.position, transform.rotation);
            m_BulletHolder.GetComponent<Rigidbody>().AddForce(transform.forward * m_BulletSpeed, ForceMode.Impulse);
            StartCoroutine(BulletDestroy());
            m_CanShoot = false;
            
        }
        
    }
    
    IEnumerator BulletDestroy()
    {
        yield return new WaitForSeconds(m_BulletLifeTime);
        Destroy(m_BulletHolder);
        m_CanShoot = true;
    }
        
}
