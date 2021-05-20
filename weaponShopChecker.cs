using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponShopChecker : MonoBehaviour
{
    public GameObject RifPrice;
    public GameObject Rif2Price;
    public GameObject LigPrice;
    public GameObject Lig2Price;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (weaponShop.rifBuy == true)
        {
            RifPrice.SetActive(false);

        }
        if (weaponShop.rif2Buy == true)
        {
            Rif2Price.SetActive(false);
        }
        if (weaponShop.ligBuy == true)
        {
            LigPrice.SetActive(false);
        }
        if (weaponShop.lig2Buy == true)
        {
            Lig2Price.SetActive(false);
        }
    }
    
}
