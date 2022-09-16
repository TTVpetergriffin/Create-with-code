using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private GameObject dog;
    bool cd = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
            if (dog == null)
        {
            dog = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                if (dog != null) cd = true;
        }
    }
}
