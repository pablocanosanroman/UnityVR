using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class IntroScreen : MonoBehaviour
{

    [SerializeField] private GameObject m_SettingsPanel;
    [SerializeField] private GameObject m_IntroScreen;
    [SerializeField] private AudioMixer m_AudioMixer;
    [SerializeField] private Slider m_MasterSlider;
    [SerializeField] private Slider m_SFXSlider;
    private float m_MasterVolume = 1.0f;
    private float m_SFXVolume = 1.0f;

    private void Start()
    {
        PlayerPrefs.GetFloat("MasterVolumeSave");
        PlayerPrefs.GetFloat("SFXVolumeSave");
        m_MasterSlider.value = m_MasterVolume;
        m_SFXSlider.value = m_SFXVolume;
    }

    private void Update()
    {
        PlayerPrefs.SetFloat("MasterVolumeSave",m_MasterVolume);    
        PlayerPrefs.SetFloat("SFXVolumeSave",m_SFXVolume);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void SettingsButton()
    {
        m_IntroScreen.SetActive(false);
        m_SettingsPanel.SetActive(true);
    }

    public void MasterVolumeSlider(float masterVolume)
    {
        m_MasterVolume = masterVolume;
        m_AudioMixer.SetFloat("MasterVolume", Mathf.Log10(m_MasterVolume) * 20.0f);
        
    }

    public void SFXVolumeSlider(float SFXVolume)
    {
        m_SFXVolume = SFXVolume;
        m_AudioMixer.SetFloat("SFXVolume", Mathf.Log10(m_SFXVolume) * 20.0f);
    }
    public void BackToIntro()
    {
        m_IntroScreen.SetActive(true);
        m_SettingsPanel.SetActive(false);
    }

    public void BackToMainScreen()
    {
        SceneManager.LoadScene("IntroScreen", LoadSceneMode.Single);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
