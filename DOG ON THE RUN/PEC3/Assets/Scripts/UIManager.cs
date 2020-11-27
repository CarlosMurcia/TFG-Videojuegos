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
        audioManager.gameObject.SetActive(true); 
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
        SceneManager.LoadScene("MainMenu");
    }
     public void Update()
    {
        if (Input.GetKey("escape"))
	{ 
        
        audioManager.gameObject.SetActive(false);
        
        Time.timeScale=0;
        optionsPanel.SetActive(true);
    }
}

   
}

