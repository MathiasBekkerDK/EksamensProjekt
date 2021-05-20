using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    //S�tter det start-v�benet til f�rste sprite under parenten.
    public int selectedWeapon = 0;

    public static float currentBulletSpeed = 10f;

    public float fireRate = 0.15f;

    public float weaponDmg = 0.33f;


    // Start is called before the first frame update
    void Start()
    {
        currentBulletSpeed = 10f;

    //K�rer metoden som det f�rste og disabler alle andre v�ben GameObjects
    SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {

        int previousSelectedWeapon = selectedWeapon;
        //Hvis man trykker p� 1 s�tter den det valgte v�ben til den f�rste sprite
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedWeapon = 0;
            currentBulletSpeed = 10f;
            fireRate = 0.15f;
            weaponDmg = 0.33f;

        }
        //Hvis man trykker p� 2 s�tter den det valgte v�ben til den anden sprite
        if (Input.GetKeyDown(KeyCode.Alpha2) && weaponShop.rifBuy == true)
        {
            selectedWeapon = 1;
            currentBulletSpeed = 15f;
            fireRate = 0.25f;
            weaponDmg = 0.75f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && weaponShop.rif2Buy == true)
        {
            selectedWeapon = 2;
            currentBulletSpeed = 20f;
            fireRate = 0.2f;
            weaponDmg = 1f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && weaponShop.ligBuy == true)
        {
            selectedWeapon = 3;
            currentBulletSpeed = 25f;
            fireRate = 0.15f;
            weaponDmg = 1.25f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && weaponShop.lig2Buy == true)
        {
            selectedWeapon = 4;
            currentBulletSpeed = 30f;
            fireRate = 0.1f;
            weaponDmg = 2f;
        }
        //Hvis det nye valgte v�ben ikke er lig med det tidligere valgte v�ben k�rer den metoden SelectWeapon
        if (previousSelectedWeapon != selectedWeapon)
        {
            SelectWeapon();
        }
    }
    void SelectWeapon()
    {
        //Hvis i er lig med det nummer sprite s�tter den GameObjectet til active, og hvis i ikker er lig med det nummer sprite disabler den GameObjectet.
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
