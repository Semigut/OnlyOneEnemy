using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menue : MonoBehaviour
{

    public void StartScreen()
    {

        SceneManager.LoadScene("StartScreen");
    }
    void Update()
    {

        if (Input.GetKeyDown("return") || Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("StartScreen");
        }
    }

    void EnterKey()
    {
        if (Input.GetKeyDown("return") || Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene("StartScreen");
        }

    }
}

