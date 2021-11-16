using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public float speed = 10;
    public float t = 5f;
    public float lerpRotation = 40;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if ((Input.acceleration.x < -0.2f || Input.GetKey("q")) && transform.position.x > -2.5)
        {
            transform.position -= Time.deltaTime * transform.right * speed * (1 - Input.acceleration.x);
            if (transform.position.y > -1.5)
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, lerpRotation), Time.deltaTime * t);
        }
        if ((Input.acceleration.x > 0.2f || Input.GetKey("d")) && transform.position.x < 2.5)
        {
            transform.position += Time.deltaTime * transform.right * speed * (1 + Input.acceleration.x);
            if (transform.position.y > -1.5)
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -lerpRotation), Time.deltaTime * t);
        }

        if (((Input.acceleration.y > -0.4f && Input.acceleration.y != 0) || Input.GetKey("z")) && transform.position.y < 5)
        {
            transform.position += Time.deltaTime * transform.up * speed * (1 - Input.acceleration.y);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-lerpRotation, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z), Time.deltaTime * t);
        }
        if ((Input.acceleration.y < -0.8f || Input.GetKey("s")) && transform.position.y > -1.5)
        {
            transform.position -= Time.deltaTime * transform.up * speed * (1 - Input.acceleration.y);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(lerpRotation, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z), Time.deltaTime * t);

        }
        transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y, 0.5f), Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * t));
        Camera.main.GetComponent<Transform>().SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);

    }
}
