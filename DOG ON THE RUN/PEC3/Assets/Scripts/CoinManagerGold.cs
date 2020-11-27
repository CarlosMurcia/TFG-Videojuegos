using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManagerGold : MonoBehaviour
{
    public Text totalGold;
    public Text goldCollected;
    private int totalGoldInLevel;
 

    private void Start()
    {
        totalGoldInLevel = transform.childCount;
    }
    void Update()
    {
        totalGold.text = totalGoldInLevel.ToString();
        goldCollected.text = (totalGoldInLevel-transform.childCount).ToString();   
    }
}
