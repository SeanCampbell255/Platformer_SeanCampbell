/*
     hmwk4_scampbell48_Obstacle.cs
    
     Sean Campbell
     Account: scampbell48
     CSc 4821
     Homework 4
     Due date: 11/19
    
     Description:
         Upon player collision this self-destructs and causes player to lose a life
     Input:
         Collision event
     Output:
         Signals Game to lose a life and destroys self
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Game game;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            game.LoseLife(1);

            Destroy(this.gameObject);
        }
    }
}
