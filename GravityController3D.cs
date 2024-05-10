using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController3D : MonoBehaviour
{
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
                Physics.gravity = new Vector3(0, -50, 20);
            }

            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                downGrav.Play();
                Physics.gravity = new Vector3(0, -50, -20);
            }

            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                leftGrav.Play();
                Physics.gravity = new Vector3(20, -50, 0);
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rightGrav.Play();
                Physics.gravity = new Vector3(-20, -50, 0);
            }
        }

    }
}
