using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{

    public float timerSeconds;
    public float songLength;
    public GameObject obj;
    private bool songPlayed;
    private static float z = 15;
    private static float xy = 2.5f;

    public Vector3[] vecPos = new[] { new Vector3(0, 0, z), new Vector3(0, xy, z), new Vector3(0, 2 * xy, z), new Vector3(xy, 0, z), new Vector3(xy, xy, z), new Vector3(xy, 2 * xy, z), new Vector3(-xy, 0, z), new Vector3(-xy, xy, z), new Vector3(-xy, 2 * xy, z) };

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = SongController.selectedAudioClip.length;
        songLength = SongController.selectedAudioClip.length + 0.01f;
        InvokeRepeating("Spawn", 2, (60 / SongController.bpm) * 2);
        InvokeRepeating("CountDown", 2, 1);

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(AudioSettings.dspTime);
    }
    void Spawn()
    {
        if (!songPlayed)
        {
            GetComponent<AudioSource>().clip = SongController.selectedAudioClip;

            GetComponent<AudioSource>().Play();
            songPlayed = true;
        }
        /*
        if (timerSeconds < songLength / 4)
        {
            Difficulty(3);
        }
        */
        if (timerSeconds < songLength / 2)
        {
            Difficulty(2);
        }
        else if (timerSeconds < songLength)
        {
            Difficulty(1);

        }
    }

    void CountDown()
    {

        timerSeconds--;

        if (timerSeconds < 1)

        {

            SceneManager.LoadScene("FinalScore");
            CancelInvoke("CountDown");


        }
        if (timerSeconds < 7)

        {
            CancelInvoke("Spawn");


        }

    }
    void Difficulty(int diff)
    {
        int rnd = Random.Range(1, diff);
        for (int i = 0; i < rnd; i++)
        {
            obj.transform.localPosition = vecPos[Random.Range(0, 9)];
            Instantiate(obj, obj.transform);
        }

    }

}
