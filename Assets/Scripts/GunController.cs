using Assets.Scripts.Weapon;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Weapon weapon;
    public Transform positionWeapon;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AssignGun(IWeaponFactory weaponFactory)
    {
        weapon = weaponFactory.CreateWeapon(1);
        // G�n s�ng cho tay nh�n v?t ho?c n?i kh�c t�y theo thi?t k? c?a b?n


    }
}
