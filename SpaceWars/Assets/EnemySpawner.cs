using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnTime;
    public float spawnTimeRandom;
    public GameObject prefabToSpawn;

    private float spawnTimer;
    
    void Start()
    {
        ResetSpawnTimer();
    }

    
    void Update()
    {
        if (!Player.isDead)
        {
            spawnTimer -= Time.deltaTime;
            if (spawnTimer <= 0.0f)
            {
                float randX = Random.Range(0, 16);
                float randY = Random.Range(0, 8);

                Instantiate(prefabToSpawn, new Vector3(transform.position.x + randX, transform.position.y - randY, transform.position.z), Quaternion.identity);
                ResetSpawnTimer();
            }
        }
    }

    void ResetSpawnTimer()
    {
        spawnTimer = (float)(spawnTime + Random.Range(0, spawnTimeRandom * 100) / 100);
    }
}
