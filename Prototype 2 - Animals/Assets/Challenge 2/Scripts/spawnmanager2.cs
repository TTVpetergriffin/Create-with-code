using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager2 : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float _spawnLimitXLeft = -22;
    private float _spawnLimitXRight = 7;
    private float _spawnPosY = 30;

    private float startDelay = 1.0f;
    private float _spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SpawnRandomBall), _spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(_spawnLimitXLeft, _spawnLimitXRight), _spawnPosY, 0);

        // Generate random prefab index and random spawn delay before running SpawnRandomBall again
        int spawnIndex = Random.Range(0, ballPrefabs.Length - 1);
        float randomInterval = Random.Range(3f, 5f);

        // Instantiate ball at random spawn location
        Instantiate(ballPrefabs[spawnIndex], spawnPos, ballPrefabs[0].transform.rotation);

        // Invoke this function again making an infinite recursion 
        Invoke(nameof(SpawnRandomBall), randomInterval);
    }

}
