/*
     hmwk4_scampbell48_Game.cs
    
     Sean Campbell
     Account: scampbell48
     CSc 4821
     Homework 4
     Due date: 11/19
    
     Description:
         Controls the game state, including scene management and numerical values like score
     Input:
         Keyboard inputs, parameters to increase score or decrease lives
     Output:
         Changes scenes, signals UI to update
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public int lives = 3;
    public int score = 0;

    public UI ui;

    //Allows this scripts methods to be accessed from other scripts
    public static Game GM;

    //Makes it so this script persists between levels
    private void Awake()
    {
        GM = this;
        DontDestroyOnLoad(gameObject);
    }

    //Allows game to be restarted from game over scene
    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "GameOver" && Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Level1");
        }
    }

    //Increases score for each life and loads next scene
    public void LevelComplete()
    {
        IncreaseScore(100 * lives);

        if(SceneManager.GetActiveScene().name == "Level1")
        {
            SceneManager.LoadScene("Level2");
        } else
        {
            GameOver();
        }
    }

    //Loads game over scene
    public void GameOver()
    {
        Debug.Log("Gameover");
        SceneManager.LoadScene("GameOver");
    }

    //Decrements lives and updates ui, also checks for gameover
    public void LoseLife(int livesLost)
    {
        lives -= livesLost;
        ui.UpdateLives(lives);
        if(lives <= 0)
        {
            GameOver();
        }
    }

    //Increases score and updates ui
    public void IncreaseScore(int scoreToAdd)
    {
        score += scoreToAdd;
        ui.UpdateScore(score);
    }
}
