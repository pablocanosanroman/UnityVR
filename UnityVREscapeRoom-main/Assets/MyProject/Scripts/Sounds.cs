using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sounds
{ 
    public string m_Name;

    public AudioClip m_SoundClip;

    public AudioMixerGroup m_MixerGroup;

    [Range(0f, 1f)]
    public float m_Volume;
    [Range(0.1f, 3f)]
    public float m_Pitch;

    public bool m_Loop;

    [HideInInspector]
    public AudioSource m_Source;

    
}
