using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletspawner : MonoBehaviour
{
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 1)
        {
            StartCoroutine(Shoot());
            Instantiate(Bullet, transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0 || transform.position.z < -12.43684)
        {
            Destroy(gameObject);
        }
    }
    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(5);
        Instantiate(Bullet, transform.position, transform.rotation);
        StartCoroutine(Shoot());
    }
}
