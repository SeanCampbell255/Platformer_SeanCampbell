/*
     hmwk4_scampbell48_Fall.cs
    
     Sean Campbell
     Account: scampbell48
     CSc 4821
     Homework 4
     Due date: 11/19
    
     Description:
         Makes Player lose a life and reset position upon falling
     Input:
         Collision event
     Output:
         Signals Game to lose life, resets player position
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    //Lose life and reset position when player falls into this object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Game.GM.LoseLife(1);

            collision.transform.position = Vector2.zero;
        }
    }
}
