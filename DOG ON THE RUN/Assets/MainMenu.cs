﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneGame ()
    {
        SceneManager.LoadScene ("Level1");
    }

    public void LoadLevel (string nameLevel)
    {
        SceneManager.LoadScene ("nameLevel");
    }

    public void Exit ()
    {
        Application.Quit ();
    }
}
