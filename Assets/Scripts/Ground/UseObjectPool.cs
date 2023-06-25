using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseObjectPool : MonoBehaviour
{

    public GameObject poolObject;

    public int pootsAmount;

    List<GameObject> poolObjects;

    // Start is called before the first frame update
    void Start()
    {
        poolObjects = new List<GameObject>();

        for(int i = 0; i < pootsAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(poolObject);
            obj.SetActive(false);
            poolObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for(int i = 0;i < poolObjects.Count; i++)
        {
            if (!poolObjects[i].activeInHierarchy)
            {
                return poolObjects[i];
            }
        }
        GameObject obj = (GameObject)Instantiate(poolObject);
        obj.SetActive(false);
        poolObjects.Add(obj);
        return obj;
    }
}
