/*
     hmwk4_scampbell48_UI.cs
    
     Sean Campbell
     Account: scampbell48
     CSc 4821
     Homework 4
     Due date: 11/19
    
     Description:
         Updates the UI
     Input:
         Lives and Score from parameters
     Output:
         Visually updates score and lives
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public Text scoreText;
    public Text liFeText;
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void UpdateLives(int lives)
    {
        liFeText.text = "Lives: " + lives;
    }

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }
}
