using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayerMenu : MonoBehaviour
{


    public GameObject player;


   public void SetPlayerBoy()
   {
       PlayerPrefs.SetString("PlayerSelected","Boy");
       ResetPlayerSkin();
   }

   public void SetPlayerGirl()
   {
       PlayerPrefs.SetString("PlayerSelected","Girl");
       ResetPlayerSkin();
   }

   void ResetPlayerSkin()
   {
       player.GetComponent<PlayerSelect>().ChangePlayerInMenu();
   }
}
