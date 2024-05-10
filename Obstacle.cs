using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverMenu;
    public GameObject redHex;
    public GameObject yellowHex;
    public TextMeshProUGUI gameOverText;

    [Header("SFX")]
    public AudioSource gameOverSfx;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player3"))
        {
            gameOverText.text = "You touched the spike";
            GameManager.instance.GameOver();
            player.SetActive(false);
            gameOverMenu.SetActive(true);
            gameOverSfx.Play();
        }
        if (collision.gameObject.CompareTag("Player4"))
        {
            gameOverText.text = "You touched the spike";
            GameManager.instance.GameOver();
            player.SetActive(false);
            gameOverMenu.SetActive(true);
            gameOverSfx.Play();
        }


        if (collision.gameObject.CompareTag("RedHex"))
        {
            gameOverText.text = "Red hexagon touched the spike";
            GameManager.instance.GameOver();
            redHex.SetActive(false);
            gameOverMenu.SetActive(true);
            gameOverSfx.Play();
        }

        if (collision.gameObject.CompareTag("YellowHex"))
        {
            gameOverText.text = "Yellow hexagon touched the spike";
            GameManager.instance.GameOver();
            yellowHex.SetActive(false);
            gameOverMenu.SetActive(true);
            gameOverSfx.Play();
        }
    }
}
