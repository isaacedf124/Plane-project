using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    

    private float spawnRangeX = 7.6f;
    private float spawnZMin = 10; // set min spawn Z remove z min and max, set 1 number, 15
    private float spawnZMax = 10; // set max spawn Z

    public int enemyCount;
    public int waveCount = 1;


    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("badPlane").Length;

        if (enemyCount == 0)
        {
            SpawnEnemyWave(waveCount);
            {
                waveCount++;
            }
        }

    }

    // Generate random spawn position for powerups and enemy plane
    Vector3 GenerateSpawnPosition()
    {
        float xPos = Random.Range(-spawnRangeX, spawnRangeX);
        float zPos = Random.Range(spawnZMin, spawnZMax);
        return new Vector3(xPos, 0, zPos);
    }


    void SpawnEnemyWave(int enemiesToSpawn)
    {
        // Spawn number of enemy plane based on wave number
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }

    }

    
}
