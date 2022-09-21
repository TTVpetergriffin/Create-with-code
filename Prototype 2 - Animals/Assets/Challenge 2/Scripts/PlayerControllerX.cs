using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireDelay = 0.1f;

    // Update is called once per frame
    void Update()
    {
        fireDelay -= 0.1f;
        Debug.Log("fireDelay: " + fireDelay);
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && fireDelay <= 0)
        {
         Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            fireDelay = 40f;
            Debug.Log("fireDelay after instantiate: " + fireDelay);

        }
        else
        {
            Debug.Log("not Delayed");
        }
    }
}
