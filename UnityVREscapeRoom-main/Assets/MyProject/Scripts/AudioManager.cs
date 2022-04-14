using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sounds[] m_Sounds;

    private void Awake()
    {
        foreach(Sounds sound in m_Sounds)
        {
            sound.m_Source = gameObject.AddComponent<AudioSource>();
            sound.m_Source.clip = sound.m_SoundClip;
            sound.m_Source.volume = sound.m_Volume;
            sound.m_Source.pitch = sound.m_Pitch;
            sound.m_Source.loop = sound.m_Loop;
        }
    }

    private void Start()
    {
        Play("MainTheme");
    }

    public void Play(string soundName)
    {
        foreach (Sounds sound in m_Sounds)
        {
            if(sound.m_Name == soundName)
            {
                Debug.Log("Playing");
                sound.m_Source.Play();
            }
        }
    }
}
