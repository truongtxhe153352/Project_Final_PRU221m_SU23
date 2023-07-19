using Assets.Scripts.Weapon.Blow;
using Assets.Scripts.Weapon.Gun;
using Assets.Scripts.Weapon.Stone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Weapon
{
    public class WeaponFactory : IWeaponFactory
    {
        public Weapon CreateWeapon(int choice)
        {
            switch (choice)
            {
                case 0:
                    {
                        return new StoneScript();
                    }
                case 1:
                    {
                        return new BlowScript();
                    }
                case 2:
                    {
                        return new GunScript();
                    }
                default:
                    throw new ArgumentException("Invalid weapon type");
            }
            
        }
    }
}
