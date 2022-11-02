using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject MetalBall;
    public bool Mshootcd;
    // Start is called before the first frame update
    void Start()
    {
        Mshootcd = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && GameObject.FindGameObjectsWithTag("Player").Length == 1 && Mshootcd == true)
        {
            Instantiate(MetalBall, transform.position, transform.rotation);
            Mshootcd = false;
            StartCoroutine(MshootCool());
        }
    }
    IEnumerator MshootCool(){
        yield return new WaitForSeconds(1);
        Mshootcd = true;
    }
}
