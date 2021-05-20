using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarSwitching : MonoBehaviour
{
    //Sætter det start-våbenet til første sprite under parenten.
    public int selectedHotbar = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Kører metoden som det første og disabler alle andre våben GameObjects
        SelectHotbar();
    }

    // Update is called once per frame
    void Update()
    {

        int previousSelectedHotbar = selectedHotbar;
        //Hvis man trykker på 1 sætter den det valgte våben til den første sprite
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedHotbar = 0;
        }
        //Hvis man trykker på 2 sætter den det valgte våben til den anden sprite
        if (Input.GetKeyDown(KeyCode.Alpha2) && weaponShop.rifBuy == true)
        {
            selectedHotbar = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && weaponShop.rif2Buy == true)
        {
            selectedHotbar = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && weaponShop.ligBuy == true)
        {
            selectedHotbar = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && weaponShop.lig2Buy == true)
        {
            selectedHotbar = 4;
        }
        //Hvis det nye valgte våben ikke er lig med det tidligere valgte våben kører den metoden SelectWeapon
        if (previousSelectedHotbar != selectedHotbar)
        {
            SelectHotbar();
        }
    }
    void SelectHotbar()
    {
        //Hvis i er lig med det nummer sprite sætter den GameObjectet til active, og hvis i ikker er lig med det nummer sprite disabler den GameObjectet.
        int i = 0;
        foreach (Transform hotbar in transform)
        {
            if (i == selectedHotbar)
                hotbar.gameObject.SetActive(true);
            else
                hotbar.gameObject.SetActive(false);
            i++;
        }
    }
}

