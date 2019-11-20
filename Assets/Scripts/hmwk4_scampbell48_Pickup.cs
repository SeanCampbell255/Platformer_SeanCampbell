/*
     hmwk4_scampbell48_Pickup.cs
    
     Sean Campbell
     Account: scampbell48
     CSc 4821
     Homework 4
     Due date: 11/19
    
     Description:
         Upon player collision this causes score to increase and self-destructs
     Input:
         Collision event
     Output:
         Signals Game to increase score by 10, destroys self
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Game game;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            game.IncreaseScore(10);

            Destroy(gameObject);
        }
    }
}
