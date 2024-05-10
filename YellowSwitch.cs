using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowSwitch : MonoBehaviour
{
    public GameObject door;
    public SpriteRenderer switchColor;
    public BoxCollider2D bc;
    public AudioSource switchSfx;

    private void Start()
    {
        switchColor = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            bc.enabled = false;
            switchSfx.Play();
            door.SetActive(false);
            switchColor.color = Color.green;
        }

        if (collision.gameObject.CompareTag("Player2"))
        {
            bc.enabled = false;
            switchSfx.Play();
            door.SetActive(false);
            switchColor.color = Color.green;
        }

        if (collision.gameObject.CompareTag("Player3"))
        {
            bc.enabled = false;
            switchSfx.Play();
            door.SetActive(false);
            switchColor.color = Color.green;
        }

        if (collision.gameObject.CompareTag("Player4"))
        {
            bc.enabled = false;
            switchSfx.Play();
            door.SetActive(false);
            switchColor.color = Color.green;
        }

        if (collision.gameObject.CompareTag("Player5"))
        {
            bc.enabled = false;
            switchSfx.Play();
            door.SetActive(false);
            switchColor.color = Color.green;
        }
    }
}
