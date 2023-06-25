using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundsGenerate : MonoBehaviour
{
    public GameObject grounds;
    public Transform generatePoint;
    float distanceBetween;
    float groundsWidth;
    public float minDistance;
    public float maxDistance;

    public UseObjectPool pool;

    void Start()
    {
        groundsWidth = grounds.GetComponent<BoxCollider2D>().size.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generatePoint.position.x)
        {
            distanceBetween = Random.Range(minDistance, maxDistance);
            transform.position = new Vector3(transform.position.x + groundsWidth + distanceBetween, Random.Range(-1, 0.5f), transform.position.z);
            // Instantiate(grounds, transform.position, transform.rotation);
            GameObject newGround = pool.GetPooledObject();
            newGround.transform.position = transform.position;
            newGround.transform.rotation = transform.rotation;
            newGround.SetActive(true);
        }
    }
}
