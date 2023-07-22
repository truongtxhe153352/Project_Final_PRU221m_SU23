using Assets.Scripts.Weapon;
using Assets.Scripts.Weapon.Stone;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponManage : MonoBehaviour
{
    private WeaponAbstractFactory weaponFactory;
    public StoneFactory stoneFactory;
    public BowFactory bowFactory;
    public GunFactory gunFactory;
    public GameObject stone;
    public GameObject bow;
    public GameObject gun;
    private bool updateBow = true;
    private bool updateGun = true;

    public Text scoreText;
    void Start()
    {
        stone.SetActive(false);
        gun.SetActive(false);
        bow.SetActive(false);
        weaponFactory = stoneFactory;
        weaponFactory.CreateWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        string []splitText = scoreText.text.Split(":");
        long score = long.Parse(splitText[1].Trim());
        if(score > 3000 && updateBow)
        {
            weaponFactory = bowFactory;
            weaponFactory.CreateWeapon();
            updateBow = false;
        }
        if (score > 5000 && updateGun)
        {
            weaponFactory = gunFactory;
            weaponFactory.CreateWeapon();
            updateGun = false;
        }
    }
}
