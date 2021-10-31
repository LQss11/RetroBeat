using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    void Update()
    {
        transform.position -= Time.deltaTime * transform.forward * 2;

        if (this.gameObject.GetComponent<Transform>().position.z < -1f)
        {

            Destroy(this.gameObject);
            HitNote.combo = 0;
            HitNote.hp -= 20;
        }
    }
}
