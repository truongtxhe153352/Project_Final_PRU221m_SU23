using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Weapon
{
    public class GunFactory : WeaponAbstractFactory
    {
        public GameObject stone;
        public GameObject bow;
        public GameObject gun;

        public override void CreateWeapon()
        {
            gun.SetActive(true);
            stone.SetActive(false);
            bow.SetActive(false);
            Debug.Log("Create gun weapon");
        }
    }
}
