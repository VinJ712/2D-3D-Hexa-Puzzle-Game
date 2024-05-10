using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XYZGravityShift : MonoBehaviour
{
    [Header("SFX")]
    public AudioSource upGrav;
    public AudioSource downGrav;
    public AudioSource leftGrav;
    public AudioSource rightGrav;

    private void Update()
    {
        if (GameManager.instance.gameState == GameState.GAME_RUNNING)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                upGrav.Play();
                Physics.gravity = new Vector3(0, -20, 20);
            }

            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                downGrav.Play();
                Physics.gravity = new Vector3(0, -20, -20);
            }

            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rightGrav.Play();
                Physics.gravity = new Vector3(20, -20, 0);
            }

            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                leftGrav.Play();
                Physics.gravity = new Vector3(-20, -20, 0);
            }

            else if (Input.GetKeyDown(KeyCode.PageUp))
            {
                upGrav.Play();
                Physics.gravity = new Vector3(0, 20, 0);
            }

            else if (Input.GetKeyDown(KeyCode.PageDown))
            {
                downGrav.Play();
                Physics.gravity = new Vector3(0, -20, 0);
            }
        }   
    }
}
