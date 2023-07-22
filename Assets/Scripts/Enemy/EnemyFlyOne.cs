using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlyOne : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 1f;
    public float spawnRangeX = 10f;
    public float spawnRangeY = 5f;

    private float nextSpawnTime;

    private void Start()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }

    private void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnEnemy();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    private void SpawnEnemy()
    {
        //Tạo vị trí ngẫu nhiên cho kẻ thù
        float spawnPosX = transform.position.x + Random.Range(0f, spawnRangeX);
        float spawnPosY = transform.position.y + Random.Range(0f, spawnRangeY);
        Vector3 spawnPos = new Vector3(spawnPosX, spawnPosY, 0f);

        // Tạo kẻ thù tại vị trí ngẫu nhiên
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}
