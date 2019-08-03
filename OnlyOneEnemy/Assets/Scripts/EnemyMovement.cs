using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private Rigidbody2D rbEnemy;
    private Vector2 startPos;
    private Vector2 newPos;
    public Rigidbody2D Temporary_RigidBody;

    //Shooting
    public GameObject Bullet_Emitter;
    public GameObject Bullet;
    public float Bullet_Forward_Force;

    float fireRate;
    float nextFire;

    private float t = 0.0f;

    private int shootcount = 0;

    public float enemySpeed;

    private float xyWert;
    private int count=0;
    private bool updown;

    //waypoints
    public GameObject[] waypoints;
    public GameObject player;
    int current = 0;
    public float speed;
    float WPradius = 1;

    private Vector3 change;
    // Use this for initialization
    void Start()
    {

        
        startPos = transform.position;
        rbEnemy = GetComponent<Rigidbody2D>();

        fireRate = 1f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {


        // MovementOne();
       Shoot();
      MovementTwo();


    }

    

    void MovementOne()
    {

        xyWert = 5;
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

    private void Shoot()
    {

        if(Time.time > nextFire)
        {

            Instantiate(Bullet, transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }

        /* t = t + Time.deltaTime;
         if (count >= 6 && t > 0.5f && shootcount <= 3)
         {

             GameObject Temporary_Bullet_Handler;




                 Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;


                 Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody2D>();

                 //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force.
                 Temporary_RigidBody.AddForce(-transform.right * Bullet_Forward_Force);


                 Destroy(Temporary_Bullet_Handler, 10.0f);
                 shootcount++;
                 t = 0.0f;
                 if (shootcount > 3)
                 {
                 count = 0;
                 shootcount = 0;
                 }

             //Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);


         }*/

    }

    public void MovementTwo()
    {

        if (Vector2.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current = Random.Range(0, waypoints.Length);
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

    }

    void OnTriggerEnter(Collider n)
    {
        if (n.gameObject == player)
        {
            player.transform.parent = transform;
        }
    }
    void OnTriggerExit(Collider n)
    {
        if (n.gameObject == player)
        {
            player.transform.parent = null;
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Counter"))
        {
            count++;
            

        }
    }

}


