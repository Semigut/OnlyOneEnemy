using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("return")){
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
