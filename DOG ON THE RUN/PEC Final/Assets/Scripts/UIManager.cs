using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class UIManager : MonoBehaviour
{

	
    
    public GameObject optionsPanel;
    public AudioSource clip;
    public GameObject audioManager;

    public void OptionsPanel()
    {
        audioManager.gameObject.SetActive(false);
        clip.Play(); 
        Time.timeScale=0;
        optionsPanel.SetActive(true);
    
    }
    public void Continue()
    {
    
        clip.Play();
         if (AudioListener.pause==false){
            audioManager.gameObject.SetActive(true);
        
        } else if (AudioListener.pause==true){
            audioManager.gameObject.SetActive(true);
            AudioListener.pause=true;
        }
        Time.timeScale=1;
        optionsPanel.SetActive(false);
    }
    public void OtherOptions()
    {
        clip.Play(); 
    }
    public void Exit()
    { 
        clip.Play();
        Time.timeScale=1;
        optionsPanel.SetActive(false); 
        SceneManager.LoadScene("MainMenu");
    }
     public void Update()
    {
       
        if ((AudioListener.pause==false)&&(Input.GetKeyDown("m"))){
            AudioListener.pause=true;
        
        } else if ((AudioListener.pause==true)&&(Input.GetKeyDown("m"))){
            AudioListener.pause=false;
        }
        if (Input.GetKey("escape")){  
            audioManager.gameObject.SetActive(false);
        
        Time.timeScale=0;
        optionsPanel.SetActive(true);
    }
    }

public void EndGAme ()
    {
        clip.Play();
        Time.timeScale=1;
        optionsPanel.SetActive(false); 
        SceneManager.LoadScene ("Level1");
        
    }
     public void BackMenu ()
    {
        clip.Play();
        Time.timeScale=1;
        optionsPanel.SetActive(false); 
        SceneManager.LoadScene ("MainMenu");
    }

}

   

