using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class MenuScript : MonoBehaviour
{

    void Start()
    {
      
    }


    void Update()
    {

    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }

    public void quitapp()
    {
        Application.Quit();
    }



}

