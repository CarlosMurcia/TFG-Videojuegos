using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{


    public AudioSource clip;


    public void SceneGame ()
    {
        clip.Play();
        SceneManager.LoadScene ("Level1");
        
    }
    public void Select ()
    {
        clip.Play();
        SceneManager.LoadScene ("SelectPlayer");

    }
    public void Options ()
    {
        clip.Play(); 
        SceneManager.LoadScene ("Options");
    }
     public void Sound ()
    {
        clip.Play(); 
        SceneManager.LoadScene ("Sound");
    }
     public void Controls ()
    {
        clip.Play(); 
        SceneManager.LoadScene ("Controls");
    }
    
    public void Exit ()
    {
        clip.Play();
        Application.Quit ();
    }
    public void BackMenu ()
    {
        clip.Play(); 
        SceneManager.LoadScene ("MainMenu");
    }
    public void BackMenuOptions ()
    {
        clip.Play(); 
        SceneManager.LoadScene ("Options");
    }

    public void MuteOn ()
    {
        AudioListener.pause=true;
    }

    public void MuteOff ()
    {
        AudioListener.pause=false;
    }
   
}
