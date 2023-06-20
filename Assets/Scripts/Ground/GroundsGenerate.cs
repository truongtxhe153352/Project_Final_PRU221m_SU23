using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundsGenerate : MonoBehaviour
{
    public GameObject grounds;
    public Transform generatePoint;
    public float distanceBetween;
    float groundsWidth;
    void Start()
    {
        groundsWidth = grounds.GetComponent<BoxCollider2D>().size.x;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generatePoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + groundsWidth + distanceBetween, Random.Range(-2, 0.75f), transform.position.z);
            Instantiate(grounds, transform.position, transform.rotation);
        }
    }
}
