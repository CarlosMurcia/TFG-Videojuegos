﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CoinCollected : MonoBehaviour
{
    public AudioSource clip;
    public int Score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.CompareTag("Player"))
       {
           GetComponent<SpriteRenderer>().enabled = false;
           gameObject.transform.GetChild(0).gameObject.SetActive(true);
           clip.Play();
           Destroy(gameObject,0.5f);
    
       }
   
        
    }

    void Update()
    {
        
    }

   


}
