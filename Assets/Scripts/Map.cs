using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        float deltaTime = Time.deltaTime;
        transform.Translate(Vector3.right * speed * deltaTime);
    }
}
