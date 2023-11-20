using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinSceneManager : MonoBehaviour
{
    

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
           
                SceneManager.LoadScene(0);
            
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
           
            SceneManager.LoadScene(2);
            
        }
    }
}
