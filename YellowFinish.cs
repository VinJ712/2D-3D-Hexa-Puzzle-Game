using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowFinish : MonoBehaviour
{
    public GameObject door;
    public AudioSource acquireSfx;
    int point = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("YellowHex") && GameManager.instance.pointManager.yellowHexPoint == 5)
        {
            acquireSfx.Play();
            GameManager.instance.pointManager.AddScore(point);
            door.SetActive(true);
        }
    }
}
