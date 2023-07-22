using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Weapon
{
    public class BowFactory : WeaponAbstractFactory
    {
        public GameObject stone;
        public GameObject bow;
        public GameObject gun;

        public override void CreateWeapon()
        {
            bow.SetActive(true);
            gun.SetActive(false);
            stone.SetActive(false);
            Debug.Log("Create bow weapon");
        }
    }
}
