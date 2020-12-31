using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{
   
   
   public bool enableSelectPlayer;
   public enum Player {Ninja, NinjaGirl};
   public Player playerSelected;

   public Animator animator;
   public SpriteRenderer spriteRenderer;

   public RuntimeAnimatorController[] playersController;
   public Sprite[] playerRenderer;

   



    void Start()
    {
        if(!enableSelectPlayer)
        {
                ChangePlayerInMenu();
        }
        else
        {
          switch (playerSelected)
 
            {
            case Player.Ninja:
                spriteRenderer.sprite = playerRenderer[0];
                animator.runtimeAnimatorController = playersController[0];
            break;

            case Player.NinjaGirl:
                spriteRenderer.sprite = playerRenderer[1];
                animator.runtimeAnimatorController = playersController[1];
            break;

            default:

            break;
            }  
        }     
    }

    
    public void ChangePlayerInMenu()
    {
       switch (PlayerPrefs.GetString("PlayerSelected"))
 
            {
            case "Boy":
                spriteRenderer.sprite = playerRenderer[0];
                animator.runtimeAnimatorController = playersController[0];
            break;

            case "Girl":
                spriteRenderer.sprite = playerRenderer[1];
                animator.runtimeAnimatorController = playersController[1];
            break;

            default:

            break;
            }  
    }

}
