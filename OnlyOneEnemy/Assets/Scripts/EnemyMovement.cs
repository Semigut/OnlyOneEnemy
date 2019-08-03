using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private Rigidbody2D rbEnemy;
    private Vector2 startPos;
    private Vector2 newPos;


    public float enemySpeed;

    private float xyWert;
    private int count=0;
    private bool updown;
    // Use this for initialization
    void Start()
    {
        startPos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        MovementOne();

    }
    
    void MovementOne()
    {

        xyWert = 8;
        updown = true;

        if (updown && count <= 6) 
        {
                     
              
                newPos = startPos;

                newPos.y = newPos.y + Mathf.PingPong(Time.time * enemySpeed, xyWert);
                
                transform.position = newPos;
                
                
            
        }
       /* else
        {
            newPos = startPos;
            newPos.x = newPos.x + Mathf.PingPong(Time.time * enemySpeed, xyWert);

            transform.position = newPos;
        }*/

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Counter"))
        {
            count++;
            Debug.Log(count);

        }
    }

}


