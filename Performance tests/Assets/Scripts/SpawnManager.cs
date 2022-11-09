using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public Coroutine coroutine;
    [SerializeField] GameObject[] Enemies;
    //private float xBorder = 9.33f;
    //private float zBorder = 9.51f;
    // Start is called before the first frame update
    void Start()
    {
        //coroutine = StartCoroutine(SpawnEvil());
        int RandomEnemies = Random.Range(0, 2);
        if (GameObject.FindGameObjectsWithTag("Player").Length == 1)
        {
            StartCoroutine(SpawnEvil());

        }
        Instantiate(Enemies[RandomEnemies], GeneratedPosition(), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            StopCoroutine(SpawnEvil);
        }
    }

    public Coroutine SpawnEvil()
    {
        yield return new WaitForSeconds(5);
        int RandomEnemies = Random.Range(0, 2);
        Instantiate(Enemies[RandomEnemies], GeneratedPosition(), Quaternion.identity);
        Debug.Log("spawned");
        StartCoroutine(SpawnEvil());

    }
    Vector3 GeneratedPosition()
    {
        {
            int x, y, z;
            x = Random.Range(-9, 9);
            y = Random.Range(1, 1);
            z = Random.Range(7, 9); return new Vector3(x, y, z);
        }
    }
}