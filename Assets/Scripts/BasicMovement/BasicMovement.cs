using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BasicMovement : MonoBehaviour
{
    Rigidbody playerRb;
   
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        
    }

    private void OnMove(InputValue inputvalue)
    {
        // Get the raw input vector
        Vector3 inputDirection = inputvalue.Get<Vector3>();

        // Normalize the input direction to ensure consistent speed
        Vector3 normalizeDirection = inputDirection.normalized;

        // Apply the velocity
        playerRb.velocity = normalizeDirection * 5;




        //Old Code to mode without normalizing
        //playerRb.velocity = inputvalue.Get<Vector3>() * 5;
    }
}
