using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class SongController : MonoBehaviour
{
    public static float bpm;
    public string songName;
    public string length;
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

        //Debug.Log(GameObject.FindGameObjectWithTag("MenuSongManager"));
        //Debug.Log(audioClips.FindIndex(a => a.name == "W O L F C L U B - California Days (Official Video)"));

        index = 0;

        GetComponent<AudioSource>().clip = selectedAudioClip;
        GetComponent<AudioSource>().Play();


        artistUI.text = selectedAudioClip.name.ToString();
        lengthUI.text = SongLength(selectedAudioClip);
        bpmUI.text = "174";
    }

    // Update is called once per frame
    void Update()
    {
        artistUI.text = selectedAudioClip.name.ToString();
        lengthUI.text = SongLength(selectedAudioClip);

        if (selectedAudioClip.name == "Donbor - Brume Magnatron III")
        {
            bpm = 220f;

        }
        else if (selectedAudioClip.name == "W O L F C L U B - California Days (Official Video)")

        {
            bpm = 150f;

        }
        else if (selectedAudioClip.name == "Lucy In Disguise - Fluorescent Moon")

        {
            bpm = 200f;

        }
        bpmUI.text = bpm.ToString();

        songName = selectedAudioClip.name.ToString();
        length = SongLength(selectedAudioClip);
    }
    public string SongLength(AudioClip ac)
    {
        var timespan = TimeSpan.FromSeconds(ac.length);
        return string.Format("{0:00}:{1:00}", timespan.Minutes, timespan.Seconds);
    }

}
