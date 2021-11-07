using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuButtons : MonoBehaviour
{

    public static bool GameIsPause = false;
    public GameObject pauseMenuUI;
    public GameObject PauseButtonUI;
    public GameObject SongPlayer;

    public void Pause()
    {
        SongPlayer.GetComponent<AudioSource>().Pause();
        PauseButtonUI.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;

    }

    public void Resume()
    {
        SongPlayer.GetComponent<AudioSource>().Play();
        PauseButtonUI.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
}
