using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverMenuUI;
    public GameObject PauseButtonUI;
    public GameObject SongPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameModController.hp <= -300)
        {
            GameModController.hp = 900;
            SongPlayer.GetComponent<AudioSource>().Pause();
            PauseButtonUI.SetActive(false);
            gameOverMenuUI.SetActive(true);
            Time.timeScale = 0f;
            PauseMenuButtons.GameIsPause = true;

        }
    }
}
