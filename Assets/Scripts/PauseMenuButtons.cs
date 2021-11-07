using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuButtons : MonoBehaviour
{

    public static bool GameIsPause = false;
    public GameObject pauseMenuUI;
    public GameObject PauseButtonUI;

    public void Pause()
    {
        PauseButtonUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;

    }

    public void Resume()
    {
        PauseButtonUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
}
