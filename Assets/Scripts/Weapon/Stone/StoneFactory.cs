using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Weapon.Stone
{
    public class StoneFactory : WeaponAbstractFactory
    {
        public GameObject stone;
        public GameObject bow;
        public GameObject gun;

        public override void CreateWeapon()
        {
            stone.SetActive(true);
            gun.SetActive(false);
            bow.SetActive(false);
            Debug.Log("Create stone weapon");
        }
    }
}
