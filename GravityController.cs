using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public GameObject up;
    public GameObject down;

    [Header("SFX")]
    public AudioSource upGrav;
    public AudioSource downGrav;
    public AudioSource leftGrav;
    public AudioSource rightGrav;

    void Update()
    {
        if (GameManager.instance.gameState == GameState.GAME_RUNNING)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                upGrav.Play();
                Physics2D.gravity = new Vector2(0, 20);
                up.gameObject.SetActive(true);
                down.gameObject.SetActive(false);
                right.gameObject.SetActive(false);
                left.gameObject.SetActive(false);
            }

            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                downGrav.Play();
                Physics2D.gravity = new Vector2(0, -20);
                down.gameObject.SetActive(true);
                left.gameObject.SetActive(false);
                up.gameObject.SetActive(false);
                right.gameObject.SetActive(false);
            }

            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rightGrav.Play();
                Physics2D.gravity = new Vector2(20, 0);
                right.gameObject.SetActive(true);
                down.gameObject.SetActive(false);
                left.gameObject.SetActive(false);
                up.gameObject.SetActive(false);
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                leftGrav.Play();
                Physics2D.gravity = new Vector2(-20, 0);
                left.gameObject.SetActive(true);
                up.gameObject.SetActive(false);
                right.gameObject.SetActive(false);
                down.gameObject.SetActive(false);
            }
        }
        
    }

}
