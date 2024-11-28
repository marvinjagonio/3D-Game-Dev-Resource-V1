using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BasicMovement : MonoBehaviour
{
    Rigidbody playerRb;
    [SerializeField] float playerJumpForce;
    [SerializeField] float playerSpeed;
   
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
        playerRb.velocity = normalizeDirection * playerSpeed;




        //Old Code to mode without normalizing
        //playerRb.velocity = inputvalue.Get<Vector3>() * 5;
    }

    private void OnJump()
    {
        playerRb.AddForce(Vector3.up * playerJumpForce, ForceMode.Impulse);
    }
}
