using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GroundsGenerate : MonoBehaviour
{
    public GameObject grounds;
    public Transform generatePoint;
    float distanceBetween;
    float groundsWidth;
    public float minDistance;
    public float maxDistance;

    public UseObjectPool[] pool;
    private int groundSelector;
    private float[] groundDistances;


    // groundHeight setting
    private float minHeight;
    private float maxHeight;
    public Transform maxHeightPoint;
    public float maxHeightChange;
    private float heightChange;

    private CoinGenerator coinGenerator;
    public float randomcoinThreadold;

    public float randomSpikeDangerThreshold;
    public UseObjectPool spikeDangerPool;


    void Start()
    {
        groundsWidth = grounds.GetComponent<BoxCollider2D>().size.x;
        groundDistances = new float[pool.Length];
        for (int i = 0; i < pool.Length; i++)
        {
            groundDistances[i] = pool[i].poolObject.GetComponent<BoxCollider2D>().size.x;
        }
        minHeight = transform.position.y;
        maxHeight = maxHeightPoint.position.y;

        coinGenerator = FindObjectOfType<CoinGenerator>();


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generatePoint.position.x)
        {
            distanceBetween = Random.Range(minDistance, maxDistance);
            groundSelector = Random.Range(0, pool.Length);

            //setting hight of ground
            heightChange = transform.position.y + Random.Range(maxHeightChange, -maxHeightChange);
            if (heightChange > maxHeight)
            {
                heightChange = maxHeight;
            }
            else if (heightChange < minHeight)
            {
                heightChange = minHeight;
            }

            //transform.position = new Vector3(transform.position.x + groundDistances[groundSelector] + distanceBetween, Random.Range(-1, 0.5f), transform.position.z);
            transform.position = new Vector3(transform.position.x + groundDistances[groundSelector] + distanceBetween, Random.Range(-1, 0.5f), transform.position.z);


            //Instantiate(theGrounds[groundSelector], transform.position, transform.rotation);
            GameObject newGround = pool[groundSelector].GetPooledObject();
            newGround.transform.position = transform.position;
            newGround.transform.rotation = transform.rotation;
            newGround.SetActive(true);

            if (Random.Range(0f, 100f) < randomcoinThreadold)
            {
                coinGenerator.SpawnCoins(new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z));
            }

            if (Random.Range(0f, 100f) < randomSpikeDangerThreshold)
            {
                GameObject newSpikeDanger = spikeDangerPool.GetPooledObject();

                float sprikeXPosition = Random.Range(-groundDistances[groundSelector] / 2f + 1, groundDistances[groundSelector] / 2f - 1) ;

                Vector3 spikeDangerPositon = new Vector3(sprikeXPosition, 0.5f, 0f);

                newSpikeDanger.transform.position = transform.position + spikeDangerPositon;

                newSpikeDanger.transform.rotation = transform.rotation;
                newSpikeDanger.SetActive(true); 
            }


        }
    }
}
