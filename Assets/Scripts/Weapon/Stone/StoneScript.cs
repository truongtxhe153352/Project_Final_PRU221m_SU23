using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Weapon.Stone
{
    public class StoneScript : MonoBehaviour
    {
        public GameObject bullet;
        private float timer;
        private float timeBetweenFire = 1f;
        private Rigidbody2D rb;
        Vector2 spawnLocation = Vector2.zero;

        void Start()
        {
        }

        void Update()
        {
            GameObject enemy = GameObject.FindGameObjectWithTag("enemy");
            if (enemy != null)
            {
                timer += Time.deltaTime;
                if (timer >= timeBetweenFire)
                {
                    GameObject shoot = Instantiate(bullet, transform.position, Quaternion.identity);
                    Vector3 directionGun = (enemy.transform.position - transform.position);
                    Rigidbody2D bulletRb = shoot.GetComponent<Rigidbody2D>();
                    bulletRb.velocity = directionGun.normalized * 25;
                    timer = 0;
                }
            }
        }
    }
}
