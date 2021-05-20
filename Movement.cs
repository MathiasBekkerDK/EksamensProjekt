using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        var movementx = Input.GetAxisRaw("Horizontal");
        var movementy = Input.GetAxisRaw("Vertical");
        //Udregner næset position og gemmer den
        Vector3 nextMove = new Vector3(movementx, movementy, 0) * moveSpeed * Time.deltaTime;
        //Udregner hvilken celle i gridden som den bevægelse vil putte playeren i.
        Vector2Int nextPositionAligned = basicPathfinding.getGridPosition(nextMove * 1.2f + transform.position);

        //Hvis den næste position man er i er en væg, bevægfer man sig ikke
        if (!gridManager.cellList[nextPositionAligned.x, nextPositionAligned.y].GetComponent<cellClass>().isWall)
        {
            transform.position += nextMove;
        }

    }
}
