using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            GameManager.instance.ResetGravity();    
            GameManager.instance.pointManager.totalPoints = 0;
            Debug.Log(GameManager.instance.pointManager.totalPoints);
            SceneManager.LoadScene("LevelTwo");
        }

        if (collision.gameObject.CompareTag("Player2"))
        {
            GameManager.instance.ResetGravity();
            GameManager.instance.pointManager.totalPoints = 0;
            Debug.Log(GameManager.instance.pointManager.totalPoints);
            SceneManager.LoadScene("LevelThree");
        }

        if (collision.gameObject.CompareTag("Player3"))
        {
            GameManager.instance.ResetGravity();
            GameManager.instance.pointManager.totalPoints = 0;
            Debug.Log(GameManager.instance.pointManager.totalPoints);
            SceneManager.LoadScene("LevelFour");
        }

        if (collision.gameObject.CompareTag("Player4"))
        {
            GameManager.instance.ResetGravity();
            GameManager.instance.pointManager.totalPoints = 0;
            Debug.Log(GameManager.instance.pointManager.totalPoints);
            SceneManager.LoadScene("LevelFive");
        }

        if (collision.gameObject.CompareTag("Player5"))
        {
            GameManager.instance.ResetGravity();
            GameManager.instance.pointManager.totalPoints = 0;
            Debug.Log(GameManager.instance.pointManager.totalPoints);
            SceneManager.LoadScene("GameFinish");
        }

    }
}
