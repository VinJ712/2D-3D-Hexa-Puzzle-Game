using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public PointManager pointManager;
    public Portal portal;
    public GameState gameState;


    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(this);
        }

        GameRunning();
    }
    void Update()
    {
        Debug.Log(pointManager.totalPoints);
    }

    public void GamePause()
    {
        gameState = GameState.PAUSED;
        Time.timeScale = 0f;
    }

    public void GameRunning()
    {
        gameState = GameState.GAME_RUNNING;
        Time.timeScale = 1.0f;
    }       

    public void GameOver()
    {
        gameState = GameState.GAME_OVER;
        Time.timeScale = 0f;  
    }

    public void ResetGravity()
    {
        Physics2D.gravity = new Vector2(0, 0);
    }

}
