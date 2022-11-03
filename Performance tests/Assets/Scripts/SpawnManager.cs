using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject BlackEnemy;
    private float xBorder = 9.33f;
    private float zBorder = 9.51f;
    private bool CD;
    // Start is called before the first frame update
    void Start()
    {
        CD = true;
        if (CD = true || GameObject.FindGameObjectsWithTag("Player").Length == 1)
        {
            StartCoroutine(SpawnEvil());

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SpawnEvil()
    {
        yield return new WaitForSeconds(5);
        Instantiate(BlackEnemy, GeneratedPosition(), Quaternion.identity);
        CD = false;
        Debug.Log("spawned");
        StartCoroutine(CoolDown());

    }
    Vector3 GeneratedPosition()
    {
        {
            int x, y, z;
            x = Random.Range(-9, 9);
            y = Random.Range(1, 1);
            z = Random.Range(-9, 9); return new Vector3(x, y, z);
        }
    }
    IEnumerator CoolDown(){
        yield return new WaitForSeconds(5);
        CD = true;
        Debug.Log("Cooldowndone");
    }
}