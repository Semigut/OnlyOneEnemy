using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    public Animator anim;

    public int live;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void Smash()
    {
        anim.SetBool("smash", true);
     


    }

    public void UnSmash()
    {
     anim.SetBool("smash", false);
        

    }
    
    public void takeDmg()
    {
        
        live--;
        
        if (live<= 0)
        {

            Destroy(this.gameObject);
            SceneManager.LoadScene("WinScreen");

        
        }
            

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Sword"))
        {



            SceneManager.LoadScene("WinScreen");


        }
    }



}
