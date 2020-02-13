using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float horizontalAxis;
    float verticalAxis;

    [SerializeField] float topForwardSpeed = 15;
    [SerializeField] float topTurnSpeed = 15;
    [SerializeField] float acceleration = 1;
    [SerializeField] float naturalSlowDown = 0.01f;


    Vector3 initialPosition;
    Vector3 movement;

    Vector3 groundedForward = new Vector3();

    bool isGrounded;

    float forwardSpeed = 0;


    void Start()
    {
        movement = new Vector3();
    }

    void Update()
    {
        GetInputs();
    }

    void FixedUpdate()
    {
        ForwardMovement();
    }

    void ForwardMovement()
    {
        if (isGrounded)
        {
            groundedForward = transform.forward;
            forwardSpeed += acceleration * verticalAxis;

            if (forwardSpeed != 0)
            {
                forwardSpeed -= (Mathf.Sign(forwardSpeed) * naturalSlowDown);
            }
        }

        if (forwardSpeed > topForwardSpeed || forwardSpeed < -topForwardSpeed)
        {
            forwardSpeed = topForwardSpeed * Mathf.Sign(forwardSpeed);
        }

        Vector3 groundForward = new Vector3(transform.forward.x, 0, transform.forward.z);
        groundForward.Normalize();
        float speedRatio = Vector3.Dot(groundForward, transform.forward.normalized);

        transform.position += groundedForward * forwardSpeed * speedRatio * Time.deltaTime;
    }

    private void GetInputs()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
