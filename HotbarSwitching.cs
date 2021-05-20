using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotbarSwitching : MonoBehaviour
{
    //S�tter det start-v�benet til f�rste sprite under parenten.
    public int selectedHotbar = 0;

    // Start is called before the first frame update
    void Start()
    {
        //K�rer metoden som det f�rste og disabler alle andre v�ben GameObjects
        SelectHotbar();
    }

    // Update is called once per frame
    void Update()
    {

        int previousSelectedHotbar = selectedHotbar;
        //Hvis man trykker p� 1 s�tter den det valgte v�ben til den f�rste sprite
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedHotbar = 0;
        }
        //Hvis man trykker p� 2 s�tter den det valgte v�ben til den anden sprite
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
        //Hvis det nye valgte v�ben ikke er lig med det tidligere valgte v�ben k�rer den metoden SelectWeapon
        if (previousSelectedHotbar != selectedHotbar)
        {
            SelectHotbar();
        }
    }
    void SelectHotbar()
    {
        //Hvis i er lig med det nummer sprite s�tter den GameObjectet til active, og hvis i ikker er lig med det nummer sprite disabler den GameObjectet.
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

