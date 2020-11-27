using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManagerSilver : MonoBehaviour
{
   
    public Text totalSilver;
    public Text silverCollected;
    private int totalSilverInLevel;

    private void Start()
    {
        totalSilverInLevel = transform.childCount;
    }
    void Update()
    {
        totalSilver.text = totalSilverInLevel.ToString();
        silverCollected.text = (totalSilverInLevel-transform.childCount).ToString();    
    }
}
