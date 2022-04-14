using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LossAndWinCanvas : MonoBehaviour
{
    public void BackToMainScreen()
    {
        SceneManager.LoadScene("IntroScreen", LoadSceneMode.Single);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}
