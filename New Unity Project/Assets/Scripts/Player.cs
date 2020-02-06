using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float horizontalAxis;
    float verticalAxis;
    [SerializeField] float speed = 5;

    void Update()
    {
        GetInputs();

        transform.position += transform.forward * verticalAxis * speed * Time.deltaTime; 
        transform.position += transform.right * horizontalAxis * speed * Time.deltaTime; 
    }

    private void GetInputs()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");
    }   
}
