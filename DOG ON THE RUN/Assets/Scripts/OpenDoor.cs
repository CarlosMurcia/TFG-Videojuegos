using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{

  private bool inDoor = false;
 

  private void OnTriggerEnter2D(Collider2D collision)
  {
      if(collision.gameObject.CompareTag("Player"))
      {
          
          inDoor=true;
          
      }
  }
 

    private void Update()
    {
       if(inDoor)
       {
            SceneManager.LoadScene ("End");
       } 
    }
}
