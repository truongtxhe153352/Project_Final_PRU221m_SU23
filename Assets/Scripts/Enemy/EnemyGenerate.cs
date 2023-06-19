using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerate : MonoBehaviour
{
    public GameObject circle;
    float timer = 0;
    public Camera mainCamera;
    void Start()
    {

    }

    void Update()
    {
        transform.position = mainCamera.transform.position;
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            timer = 0;
            //Vector2 randomDirection = Random.insideUnitCircle; // Generate a random vector inside a unit circle
            //float randomMagnitude = Random.Range(3, 7); // Generate a random force magnitude
            //Vector2 randomForce = randomDirection.normalized * randomMagnitude; // Scale the random vector by the magnitude

            Vector3 screenPosition = new Vector3(Screen.width, 0, 0);
            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(screenPosition);

            Vector3 vector3 = new Vector3(worldPosition.x, Random.Range(-1.8f, 4.3f), 0);
            GameObject obj = Instantiate<GameObject>(circle, vector3, Quaternion.identity);
            //obj.GetComponent<Rigidbody2D>().AddForce(randomForce, ForceMode2D.Impulse);

        }
    }
}
