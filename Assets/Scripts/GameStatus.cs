using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{
    public string player1Name;
    public string player2Name;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name =="Level2")
            Music.instance.GetComponent<AudioSource>().Pause();       
    }
}
