using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class Player3DController : MonoBehaviour
{
    public float walkSpeed = 6f;
    public float runSpeed = 10f;
    public float jumpPower = 5f;
    public float gravity = 7f;
    public float lookSpeed = 2f;
    public float lookXLimit = 45f;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController characterController;

    [Header("Portal Activate")]
    public Animator portalAnim;
    public GameObject portal;

    private bool canMove = true;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (GameManager.instance.gameState == GameState.GAME_RUNNING)
        {
            CharacterMovement();            
        }

        if (GameManager.instance.pointManager.totalPoints == 5)
        {
            portalAnim.SetBool("isCollectedAll", true);
        }

        if (GameManager.instance.pointManager.pressurePlatePoints == 2)
        {
            portal.SetActive(true);
        }

    }

    public void CharacterMovement()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        float curSpeedX = canMove ? walkSpeed * Input.GetAxis("Vertical") : 0;
        float curSpeedY = canMove ? walkSpeed * Input.GetAxis("Horizontal") : 0;
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = jumpPower;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
