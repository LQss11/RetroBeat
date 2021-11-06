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
        /*
    if (Input.acceleration.x > -0.1)
{

}
*/
        if (Input.GetKey("q") && transform.position.x > -2.5)
        {
            transform.position -= Time.deltaTime * transform.right * speed;
            if (transform.position.y > -1.5)
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, lerpRotation), Time.deltaTime * t);
        }
        if (Input.GetKey("d") && transform.position.x < 2.5)
        {
            transform.position += Time.deltaTime * transform.right * speed;
            if (transform.position.y > -1.5)
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -lerpRotation), Time.deltaTime * t);


        }
        if (Input.GetKey("z") && transform.position.y < 5)
        {

            transform.position += Time.deltaTime * transform.up * speed;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(-lerpRotation, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z), Time.deltaTime * t);

        }
        if (Input.GetKey("s") && transform.position.y > -1.5)
        {
            transform.position -= Time.deltaTime * transform.up * speed;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(lerpRotation, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z), Time.deltaTime * t);

        }
        transform.SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y, 0.5f), Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * t));
        Camera.main.GetComponent<Transform>().SetPositionAndRotation(new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);

    }
}
