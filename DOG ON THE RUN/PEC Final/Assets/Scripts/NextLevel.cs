using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;




public class NextLevel : MonoBehaviour
{
    public AudioSource clip;
    public GameObject audioManager;
    

    private IEnumerator WaitForSceneLoad() 
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level2");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            audioManager.gameObject.SetActive(false);
            clip.Play(); 
            StartCoroutine(WaitForSceneLoad());
        }

  }
    
}
