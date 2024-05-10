using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    bool isTimerOn = true;
    public float remainingTime;
    public TextMeshProUGUI timer;
    public GameObject GameOver;

    void Update()
    {
        if (isTimerOn == true && GameManager.instance.gameState == GameState.GAME_RUNNING)
        {
            if (remainingTime > 0)
            {
                remainingTime -= Time.deltaTime;
            }
            else if (remainingTime < 0)
            {
                GameOver.SetActive(true);               
                remainingTime = 0;
                GameManager.instance.GamePause();
            }
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
