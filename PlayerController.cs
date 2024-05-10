using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed;
    float speedX, speedY;
    public SpriteRenderer playerColor;
    public GameObject portal;
    public AudioSource portalSfx;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (GameManager.instance.gameState == GameState.GAME_RUNNING)
        {
            speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
            speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
            rb.velocity = new Vector2(speedX, speedY);
        }

        if (GameManager.instance.pointManager.totalPoints == 2 )
        {
            playerColor.color = new Color(1, 0, 1, 1);
            portal.gameObject.SetActive(true);
            
        }
    }

}
