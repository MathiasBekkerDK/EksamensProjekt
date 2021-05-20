using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float bulletSpeed = 20f;
    //Variabel til hvor meget bullet skader.
    public float dmg;

    //Reference til spriten som bulleten har
    SpriteRenderer sprite;

    //Bruges til at gemme den enemy som kollideres med.
    GameObject foundEnemy;


    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Bevæger bulleten
        transform.Translate(Vector3.right * bulletSpeed * Time.deltaTime, Space.Self);
        //Bulletens position i gridden
        Vector2Int allignedPos = basicPathfinding.getGridPosition(transform.position);

        //Skuddet fjernes hvis det er ude af banen
        if (transform.position.x < gridManager.minPoint.x || transform.position.y < gridManager.minPoint.y
            || transform.position.x > gridManager.maxPoint.x || transform.position.y > gridManager.maxPoint.y)
        {
            die();
        } //Hvis man rammer en væg, skal skuddet destrueres.
        else if (gridManager.cellList[allignedPos.x, allignedPos.y].GetComponent<cellClass>().blockbullet)
        {
            die();
        } //Hvis en enemies koordinat er indenfor bulletens sprite, kolliderer de. Bullet fjernes og enemy tager skade.
        else if (enemyPos())
        {
            foundEnemy.GetComponent<healthScript>().modifyHealth(dmg);
            die();
        }
    }

    bool enemyPos()
    {
        //Holder styr på om en enemy er fundet.
        bool enemyFound = false;
        //enemyList er en liste af alle enemies i spillet, som er i live. Denne liste køres igennem, og der testes om en af dem kolliderer med bulleten.
        foreach (Transform enemy in waveManager.enemylist)
        {
            //Gør at tomme pladser på listen ignoreres.
            if (enemy != null)
            {
                if (sprite.bounds.extents.x + transform.position.x > enemy.position.x && transform.position.x - sprite.bounds.extents.x < enemy.position.x
               && sprite.bounds.extents.y + transform.position.y > enemy.position.y && transform.position.y - sprite.bounds.extents.y < enemy.position.y)
                {
                    enemyFound = true;
                    foundEnemy = enemy.gameObject;
                    break;
                }
            }

        }
        return enemyFound;
    }

    void die ()
    {
        Destroy(gameObject);
    }
}
