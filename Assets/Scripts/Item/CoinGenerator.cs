using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public UseObjectPool UseObjectPool;

    public float distanceBeetweenCoin;

    public void SpawnCoins(Vector3 startPosition)
    {
        GameObject coin1 = UseObjectPool.GetPooledObject();
        coin1.transform.position = startPosition;
        coin1.SetActive(true);

        GameObject coin2 = UseObjectPool.GetPooledObject();
        coin2.transform.position = new Vector3(startPosition.x - distanceBeetweenCoin, startPosition.y, startPosition.z);
        coin2.SetActive(true);

        GameObject coin3 = UseObjectPool.GetPooledObject();
        coin3.transform.position = new Vector3(startPosition.x - distanceBeetweenCoin, startPosition.y, startPosition.z);
        coin3.SetActive(true);
    }
}
