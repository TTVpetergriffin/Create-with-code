using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 1)
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if (transform.position.z < -12.43684)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player" || collision.gameObject.tag == "Mball")
        {
            Destroy(collision.gameObject);
        }
    }
}
