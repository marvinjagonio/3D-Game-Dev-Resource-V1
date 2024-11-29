using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Animator playerAnim;
    Rigidbody playerRb;
    [SerializeField] float playerMovementSpeed;

    private Animator animator;

    private void Start()
    {
        //playerAnim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();
        Debug.Log(animator);
    }

    private void OnMove(InputValue inputvalue)
    {
        playerRb.velocity = inputvalue.Get<Vector3>() * playerMovementSpeed;
    }


}
