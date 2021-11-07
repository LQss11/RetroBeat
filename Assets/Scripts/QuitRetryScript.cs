using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitRetryScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void Retry()
    {
        SceneManager.LoadScene("PrototypeScene");

    }
    public void Quit()
    {
        SceneManager.LoadScene("MapSelect");
    }
}
