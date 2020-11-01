using System.Collections;
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
    public void Options ()
    {
        SceneManager.LoadScene ("Options");
    }
     public void Sound ()
    {
        SceneManager.LoadScene ("Sound");
    }
     public void Controls ()
    {
        SceneManager.LoadScene ("Controls");
    }
    public void Score ()
    {
        SceneManager.LoadScene ("Score");
    }
    public void Exit ()
    {
        Application.Quit ();
    }
    public void BackMenu ()
    {
        SceneManager.LoadScene ("MainMenu");
    }
    public void BackMenuOptions ()
    {
        SceneManager.LoadScene ("Options");
    }
}
