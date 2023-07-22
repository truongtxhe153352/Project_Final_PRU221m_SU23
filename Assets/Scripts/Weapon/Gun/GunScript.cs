using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Weapon.Gun
{
    public class GunScript : MonoBehaviour
    {

        public GameObject bullet;
        public Transform nongsung;
        private float timer;
        private float timeBetweenFire = 1f;
        private Rigidbody2D rb;
        Vector2 spawnLocation = Vector2.zero;
        private float yPositionForRotate = 0.3f;
        private float xPosiotionForRotate = 0.3f;

        void Start()
        {
        }

        void Update()
        {
            GameObject enemy = GameObject.FindGameObjectWithTag("enemy");
            if (enemy != null)
            {
                Vector2 direction = enemy.transform.position - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                // Calculate the opposite angle
                float oppositeAngle = angle;
                // Set the rotation of this object to the opposite angle
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, oppositeAngle));

                if (transform.eulerAngles.z > 90 && transform.eulerAngles.z < 270)
                {
                    Vector3 vtr = new Vector3(transform.localScale.x, -transform.localScale.y, 0);
                    transform.localScale = new Vector3(xPosiotionForRotate, -yPositionForRotate, 0);
                }
                else
                {
                    Vector3 vtr = new Vector3(transform.localScale.x, transform.localScale.y, 0);
                    transform.localScale = new Vector3(xPosiotionForRotate, yPositionForRotate, 0);
                }
                timer += Time.deltaTime;
                if (timer >= timeBetweenFire)
                {
                    // Create bullet instance
                    GameObject shoot = Instantiate(bullet, nongsung.position, Quaternion.identity);
                    shoot.transform.rotation = Quaternion.Euler(new Vector3(0, 0, oppositeAngle));
                    Vector3 directionGun = (nongsung.position - transform.position);
                    // Set bullet velocity
                    Rigidbody2D bulletRb = shoot.GetComponent<Rigidbody2D>();
                    bulletRb.velocity = directionGun.normalized * 25;
                    //shoot.GetComponent<Rigidbody2D>().AddForce(direction, ForceMode2D.Impulse);
                    timer = 0;
                }


            }

        }
    }
}
