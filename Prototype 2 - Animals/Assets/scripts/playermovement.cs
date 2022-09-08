using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playermovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 24.37f;
    // Update is called once per frame
    void Update()
    {
        // moves the player around
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        // keeps the player boxed like a fish?? idk i remember hearing that once
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
