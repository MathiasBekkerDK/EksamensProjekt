using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponShop : MonoBehaviour
{
    public static bool subBuy = true;
    public static bool rifBuy = false;
    public static bool rif2Buy = false;
    public static bool ligBuy = false;
    public static bool lig2Buy = false;

    // Start is called before the first frame update
    void Start()
    {
        subBuy = true;
        rifBuy = false;
        rif2Buy = false;
        ligBuy = false;
        lig2Buy = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Hvis man trykker på 2 sætter den det valgte våben til den anden sprite
        if (Input.GetKeyDown(KeyCode.Alpha2) && moneyScript.moneyz >= 50)
        {
            moneyScript.moneyz = moneyScript.moneyz - 50;
            rifBuy = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && moneyScript.moneyz >= 100)
        {
            moneyScript.moneyz = moneyScript.moneyz - 100;
            rif2Buy = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && moneyScript.moneyz >= 150)
        {
            moneyScript.moneyz = moneyScript.moneyz - 150;
            ligBuy = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && moneyScript.moneyz >= 200)
        {
            moneyScript.moneyz = moneyScript.moneyz - 200;
            lig2Buy = true;
        }
    }
}
