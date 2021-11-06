using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSong : MonoBehaviour
{
    private int i;
    // Start is called before the first frame update
    public void next()
    {
        i = SongController.index;
        i++;
        if (SongController.audioClips.Count-1 < i)
        {
            SongController.selectedAudioClip = SongController.audioClips[0];
            SongController.index = 0;
        }
        else
        {
            SongController.selectedAudioClip = SongController.audioClips[i];
            SongController.index++;
        }
        Debug.Log("i =  " + i + " index is " + SongController.index);
        GameObject.FindGameObjectWithTag("MenuSongManager").GetComponent<AudioSource>().clip = SongController.selectedAudioClip;
        GameObject.FindGameObjectWithTag("MenuSongManager").GetComponent<AudioSource>().Play();
    }
    public void back()
    {
        i = SongController.index;

        i--;
        if (i < 0)
        {
            SongController.selectedAudioClip = SongController.audioClips[SongController.audioClips.Count-1];
            SongController.index = SongController.audioClips.Count - 1;
        }
        else
        {
            SongController.selectedAudioClip = SongController.audioClips[i];
            SongController.index--;
        }
        Debug.Log("i =  " + i + " index is " + SongController.index);
        GameObject.FindGameObjectWithTag("MenuSongManager").GetComponent<AudioSource>().clip = SongController.selectedAudioClip;
        GameObject.FindGameObjectWithTag("MenuSongManager").GetComponent<AudioSource>().Play();
    }
}
