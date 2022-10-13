using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    public int policeCount;
    public int waveNumber = 0;
    public GameObject Steroids;
    // Start is called before the first frame update
    void Start()
    {
    }
    
    

    // Update is called once per frame
    void Update()
    {
        policeCount = FindObjectsOfType<Enemy>().Length;
        if (policeCount == 0) {waveNumber++;  SpawnEnemyWave(waveNumber); }
        if (policeCount == 0) {Instantiate(Steroids, GenerateSpawnPosition(), Steroids.transform.rotation);}
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i =0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}
