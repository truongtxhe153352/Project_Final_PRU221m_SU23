using Assets.Scripts.Weapon.Gun;
using Assets.Scripts.Weapon.Stone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Weapon
{
    public abstract class WeaponAbstractFactory : MonoBehaviour
    {
        public abstract void CreateWeapon();
    }
}
