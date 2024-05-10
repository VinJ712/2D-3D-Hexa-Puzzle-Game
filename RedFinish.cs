using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class RedFinish : MonoBehaviour
{
    public GameObject door;
    public AudioSource acquireSfx;
    int point = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RedHex") && GameManager.instance.pointManager.redHexPoint == 5)
        {
            acquireSfx.Play();
            GameManager.instance.pointManager.AddScore(point);
            door.SetActive(true);
        }
    }
}
