using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Start : MonoBehaviour
{
   public void StartGame()
    {

        SceneManager.LoadScene("FirstLevel");
    }

    void Update()
    {

        if (Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene("FirstLevel");
        }
    }

    void EnterKey()
    {
        if (Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene("FirstLevel");
        }

    }
}
