using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterWin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene("StartScreen");
        }
    }

    void EnterKey()
    {
        if (Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene("StartScreen");
        }

    }
}
