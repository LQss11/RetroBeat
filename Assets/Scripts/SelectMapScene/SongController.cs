using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class SongController : MonoBehaviour
{
    public static float bpm;
    public string songName;
    public List<AudioClip> ac2;

    public Text artistUI;
    public Text bpmUI;
    public Text lengthUI;


    public static List<AudioClip> audioClips;
    public static AudioClip selectedAudioClip;
    public static int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioClips = ac2;
        selectedAudioClip = audioClips[0];

        index = 0;

        GetComponent<AudioSource>().clip = selectedAudioClip;
        GetComponent<AudioSource>().Play();


        artistUI.text = selectedAudioClip.name.ToString();
        lengthUI.text = SongLength(selectedAudioClip);
        bpmUI.text = "100";
    }

    // Update is called once per frame
    void Update()
    {

        songName = selectedAudioClip.name.ToString();
        if (songName == "Donbor - Brume Magnatron III")
        {
            bpm = 110f;

        }
        else if (songName == "W O L F C L U B - California Days (Official Video)")

        {
            bpm = 150f;

        }
        else if (songName == "Lucy In Disguise - Fluorescent Moon")

        {
            bpm = 100f;

        }
        else if (songName == "Driver86 - Not Like Us (feat. Oceanside85)")

        {
            bpm = 105f;

        }
        else if (songName == "Creative Commons Synthwave")

        {
            bpm = 130f;

        }
        else if (songName == "Demo Song")

        {
            bpm = 150f;

        }


        artistUI.text = selectedAudioClip.name.ToString();
        lengthUI.text = SongLength(selectedAudioClip);

        bpmUI.text = bpm.ToString();

        Debug.Log("Song name = " + songName + " and Bpm = " + bpm);

    }
    public string SongLength(AudioClip ac)
    {
        var timespan = TimeSpan.FromSeconds(ac.length);
        return string.Format("{0:00}:{1:00}", timespan.Minutes, timespan.Seconds);
    }

}
