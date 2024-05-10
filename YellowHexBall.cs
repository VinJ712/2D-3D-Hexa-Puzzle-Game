using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class YellowHexBall : MonoBehaviour
{
    public int point = 1;
    [Header("UI")]
    public GameObject gameOverUI;
    public AudioSource collideSfx;
    public TextMeshProUGUI gameOverText;

    [Header("SFX")]
    public AudioSource pointSfx;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("YellowPoint"))
        {
            pointSfx.Play();
            GameManager.instance.pointManager.AddYellowHexPoint(point);
            Debug.Log("Yellow point: " + GameManager.instance.pointManager.yellowHexPoint);
            Destroy(collision.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("RedHex"))
        {
            GameManager.instance.GameOver();
            gameOverText.text = "Two hexagons collided with each other.";
            collideSfx.Play();
            gameOverUI.SetActive(true);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
