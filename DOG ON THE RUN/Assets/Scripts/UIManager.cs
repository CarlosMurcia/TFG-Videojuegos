using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

	
    
    public GameObject optionsPanel;

    public void OptionsPanel()
    {
       
        Time.timeScale=0;
        optionsPanel.SetActive(true);
    
    }
    public void Continue()
    {
        Time.timeScale=1;
        optionsPanel.SetActive(false);
    }
    public void OtherOptions()
    {
        
    }
    public void Exit()
    { 
        SceneManager.LoadScene("MainMenu");
    }
     public void Update()
    {
        if (Input.GetKey("escape"))
	{
        Time.timeScale=0;
        optionsPanel.SetActive(true);
    }
    }
    }
