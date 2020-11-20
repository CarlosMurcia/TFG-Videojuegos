using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarHealth : MonoBehaviour
{
    public Image health;
    float hp;
    float maxHp = 100f;
    public Animator animator;
    public GameObject optionsPanel;


    void Start()
    {
      hp =  maxHp; 
    }

    public void TakeDamage(float amount)
    {
      if(hp<=0f)
      {
        animator.Play("Dead");
        Time.timeScale=0;
        optionsPanel.SetActive(true);
      }
      else
      {
      hp = Mathf.Clamp(hp-amount,0f,maxHp);
      health.transform.localScale = new Vector2(hp/maxHp, 1);   
      }
     
      
    }
}
