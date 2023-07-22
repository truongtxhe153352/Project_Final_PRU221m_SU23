using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerate : MonoBehaviour
{
    public GameObject circle;
    float timer = 0;
    public Camera mainCamera;

    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if (gameManager.isPlayerAlive)
        {
            transform.position = mainCamera.transform.position;
            timer += Time.deltaTime;
            if (timer >= 3)
            {
                timer = 0;

                Vector3 screenPosition = new Vector3(Screen.width, 0, 0);
                Vector3 worldPosition = mainCamera.ScreenToWorldPoint(screenPosition);

                Vector3 spawnPosition = new Vector3(worldPosition.x, Random.Range(-1.8f, 4.3f), 0);
                GameObject obj = Instantiate<GameObject>(circle, spawnPosition, Quaternion.identity);
            }
        }
    }

    // Add a method to reset the enemy generation logic.
    public void ResetEnemyGeneration()
    {
        timer = 0;
    }
}
