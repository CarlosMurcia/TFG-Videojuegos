using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class BarHealth : MonoBehaviour
{
    public Image health;
    float hp;
    float maxHp = 100f;
    public Animator animator;
    public GameObject optionsPanel;
    public AudioSource clip;
    public GameObject audioManager;


    void Start()
    {
      hp =  maxHp; 
    }

    public void TakeDamage(float amount)
    {
      
      if(hp<=0f)
      {
        audioManager.gameObject.SetActive(false);
        animator.Play("Dead");
        clip.Play();
        StartCoroutine("Coroutine");
        
        
        
      }
      else
      {
      hp = Mathf.Clamp(hp-amount,0f,maxHp);
      health.transform.localScale = new Vector2(hp/maxHp, 1);   
      } 
    }

    IEnumerator Coroutine()
    {
      yield return new WaitForSeconds(1);
      Time.timeScale=0;
      optionsPanel.SetActive(true);
    }
    
}
