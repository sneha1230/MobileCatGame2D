using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    //public Timer time;

    void Start()
    {
        Invoke("GoToGameScene", 2.0f);
    }
    void GoToGameScene()
    {
        SceneManager.LoadScene("StartScene");
    }
    
}

