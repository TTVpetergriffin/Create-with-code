using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float Speed = 22.5f;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    void Update()
    {
        // okay so the goal here is to get the cube movin
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == ("taggedenemy"))
        {
            Destroy(this.gameObject);
            Debug.Log("Hit Enemy");
        }
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            Debug.Log("Hit Coin");
        }
    }
}
