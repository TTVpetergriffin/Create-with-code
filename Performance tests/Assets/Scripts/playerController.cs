using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float xBorder = 9.33f;
    public float zBorder = 9.51f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("w"))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (transform.position.x > xBorder)
        {
            transform.position = new Vector3(xBorder, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xBorder)
        {
            transform.position = new Vector3(-xBorder, transform.position.y, transform.position.z);
        }
        if (transform.position.z > zBorder)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBorder);
        }
        if (transform.position.z < -zBorder)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBorder);
        }
    }
}
