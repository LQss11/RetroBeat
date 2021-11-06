using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Time.deltaTime * transform.forward * 2;

        if (transform.position.z < -1f)
        {
            Destroy(this.gameObject);
            GameModController.combo = 0;
            GameModController.hp -= 100;
        }

        /*
        Mathf.CeilToInt()

        if (1.5f> transform.position.z && player.transform.position.x==transform.position.x && player.transform.position.y == transform.position.y)
        {
            Destroy(this.gameObject);
        }
        */
    }


}
