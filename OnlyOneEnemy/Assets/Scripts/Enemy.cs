using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator anim;

    public bool change = false;
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

}
