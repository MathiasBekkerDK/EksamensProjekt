using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint1;
    private float nextFire = 0;

    //bruges til at afspille lyd
    public AudioSource shootSound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Full-auto funktion til våbnene
        if(Input.GetButton("Fire1") && Time.time > nextFire && !Input.GetKey("b") && !Input.GetKey("c"))
        {
            {
                float currentDMG = GetComponentInChildren<WeaponSwitching>().weaponDmg;
                nextFire = Time.time + GetComponentInChildren<WeaponSwitching>().fireRate;
                GameObject bullet = Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
                bullet.GetComponent<Projectile>().dmg = currentDMG;
                bullet.GetComponent<Projectile>().bulletSpeed = WeaponSwitching.currentBulletSpeed;
                //shootSound.Play();
            }
        }
    }

}
