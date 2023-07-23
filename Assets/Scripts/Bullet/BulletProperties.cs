using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProperties : MonoBehaviour
{

    public int damage;
    public int Dame
    {
        get { return damage; }
        set { damage = value; }
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject obj = other.gameObject;
        if (other.gameObject.CompareTag("enemy"))
        {
            obj.GetComponent<EnemyBehaviour>().Hp -= damage;
            Debug.Log("Dame gay ra: " + damage);
            //destroy bullet
            Destroy(gameObject);
        }
    }
}
