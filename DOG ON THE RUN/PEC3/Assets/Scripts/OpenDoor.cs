using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
 



public class OpenDoor : MonoBehaviour
{
  
  public GameObject optionsPanel;
  public AudioSource clip;
  public GameObject audioManager;
  
  
 

  private void OnTriggerEnter2D(Collider2D collision)
  {
      if(collision.gameObject.CompareTag("Player"))
      {
          
        audioManager.gameObject.SetActive(false);
        clip.Play();   
        Time.timeScale=0;
        optionsPanel.SetActive(true);    
      }
  }
    
}
