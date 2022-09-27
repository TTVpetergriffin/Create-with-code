using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour    
{
    // Start is called before the first frame update
    private float speed = 30;
    private Playercontroller playerControllerScript;
    private float leftBound = -15;
    
    void Start()
    {
        playerControllerScript = GameObject.Find("Waltuh").GetComponent<Playercontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject); }
    }
}
