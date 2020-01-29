using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//why would someone find this fun
//why would they spend money on it
//30 second trailer
public class CharacterMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    //camera transform
    private Vector3 cameraDirection = Vector3.zero;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        // let the gameObject fall down
        //gameObject.transform.position = new Vector3(0, 5, 0);
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            //Get camera position 

            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection)     ;
            moveDirection = moveDirection * speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
    }
}
