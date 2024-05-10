using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheNextLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);
            SceneManager.LoadScene("LevelTwo3D");
        }

        if (other.gameObject.CompareTag("Player2"))
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);
            SceneManager.LoadScene("LevelThree3D");
        }

        if (other.gameObject.CompareTag("Player3"))
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);
            SceneManager.LoadScene("LevelFour3D");
        }

        if (other.gameObject.CompareTag("Player4"))
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);
            SceneManager.LoadScene("LevelFive3D");
        }

        if (other.gameObject.CompareTag("Player5"))
        {
            Physics.gravity = new Vector3(0, -9.81f, 0);
            SceneManager.LoadScene("GameFinish3D");
        }

    }
}
