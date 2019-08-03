using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Continue : MonoBehaviour
{
    public void PlayGame()
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
