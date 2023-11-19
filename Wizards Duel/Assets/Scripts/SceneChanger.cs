using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
    public int sceneNumber;

    private void ExitGame()
    {
        Application.Quit();
    }
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
