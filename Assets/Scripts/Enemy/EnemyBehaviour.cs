using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    public int Hp
    {
        get { return hp; }
        set { hp = value; }
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
