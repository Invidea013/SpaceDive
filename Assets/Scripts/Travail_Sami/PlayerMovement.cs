using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Slider oxBar;
    public CharacterController controller;
    public Transform groundCheck;

    public Vector3 velocity;
    bool isGrounded;

    public float jetpackForce = 10f;
    public float jetpackDelay = 0f;

    public float moveSpeed;
    public float sprintSpeed = 10f;
    public float moveSpeedBase = 5f;
    public float jumpHeight = 3f;

    public float gravity = -9.81f;
    public float groundDistance = 0.4f;

    public float fuelUse = 0.0001f;

    public float oxBreatheBase = 0.00001f;
    public float oxBreathe;
    public float oxSprint = 0.00005f;

    public bool canJump = true;
    public bool usingJetpack = false;

    public LayerMask groundMask;

    void Start()
    {
        moveSpeed = moveSpeedBase;
        oxBreathe = oxBreatheBase;
    }

    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        Debug.Log(isGrounded);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * moveSpeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = sprintSpeed;
            oxBreathe = 0.00005f;
        }

        else
        {
            moveSpeed = moveSpeedBase;
            oxBreathe = oxBreatheBase;
        }

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = 0f;
            jetpackDelay = 0f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        oxBar.value -= oxBreathe;

        Jetpack();
    }

    public void Jetpack()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            jetpackDelay += Time.deltaTime;

            if(jetpackDelay >= 1f)
            {
                usingJetpack = true;

                if (usingJetpack == true)
                {
                    velocity.y = jetpackForce * Time.deltaTime;
                    oxBar.value -= fuelUse;
                }
            }
        }

        else
        {
            usingJetpack = false;
        }

    }

}
