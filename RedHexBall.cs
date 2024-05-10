using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHexBall : MonoBehaviour
{
    public int point = 1;

    [Header("SFX")]
    public AudioSource pointSfx;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("RedPoint"))
        {
            pointSfx.Play();
            GameManager.instance.pointManager.AddRedHexPoint(point);
            Debug.Log("Red point: " + GameManager.instance.pointManager.redHexPoint);
            Destroy(collision.gameObject);
        }

    }
}
