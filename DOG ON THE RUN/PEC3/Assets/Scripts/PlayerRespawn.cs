using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    public Animator animator;
    public GameObject optionsPanel;
    private GameObject healthBar;


   
    void Start ()
    {
       healthBar = GameObject.Find("BarHealth");
    }

     public void OptionsPanel()
    {
       
        Time.timeScale=0;
        optionsPanel.SetActive(true);
    
    }
    public void Continue()
    {
        Time.timeScale=1;
        optionsPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void Exit()
    { 
        Time.timeScale=1;
        optionsPanel.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }

    public void PlayerDamaged()
    {
        
            healthBar.SendMessage("TakeDamage",34);

    }

}
