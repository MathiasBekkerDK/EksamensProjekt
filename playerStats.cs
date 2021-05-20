using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{
    public int health = 100;
    public Slider healthBar;
    public Text healthText;
    public float invincTime;
    public GameObject fadeController;

    float tookDMGTime;

    // Start is called before the first frame update
    void Start()
    {

        healthBar.value = health;
        healthText.text = health.ToString() + "%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void modifyHealth(int healthChange)
    {
        if (Time.time > tookDMGTime + invincTime)
        {
            health -= healthChange;
            tookDMGTime = Time.time;

            healthBar.value = health;
            healthText.text = health.ToString() + "%";

            if (health <= 0)
            {
                die();
            }
        }

    }

    void die()
    {
        fadeController.GetComponent<fadeController>().fadeToBlack();

    }
}
