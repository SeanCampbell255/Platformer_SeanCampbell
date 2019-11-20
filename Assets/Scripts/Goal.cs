/*
     hmwk4_scampbell48_Goal.cs
    
     Sean Campbell
     Account: scampbell48
     CSc 4821
     Homework 4
     Due date: 11/19
    
     Description:
         Upon collision with player it causes game to change to next level
     Input:
         Collision event
     Output:
         Signals Game to go to next level
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Game.GM.LevelComplete();
        }
    }
}
