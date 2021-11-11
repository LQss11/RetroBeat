using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{


    public Text songUI;
    public Text bpmUI;
    public Text ScoreUI;
    public string songName;
    public string score;

    // Start is called before the first frame update
    void Start()
    {
        songUI.text = SongController.selectedAudioClip.name.ToString();
        bpmUI.text = SongController.bpm.ToString();
        ScoreUI.text = GameModController.currentscore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
