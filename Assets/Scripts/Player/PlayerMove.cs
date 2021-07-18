using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody playerBody;
    Vector3 inputDirection;
    Animator walkAnimator;
    float playerSpeed = 4.0f;  //public float playerSpeed = 4.0f;

    void Start()
    {
        playerBody = this.gameObject.GetComponent<Rigidbody>();
        walkAnimator = this.gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        inputDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0); //verticalをVerticalに

        if (inputDirection == Vector3.zero)
        {
            walkAnimator.speed = 0;
        }
        else
        {
            walkAnimator.speed = 1;

            walkAnimator.SetFloat("x", inputDirection.x); //Xをxにする
            walkAnimator.SetFloat("y", inputDirection.y);
        }
    }

    void FixedUpdate()
    {
        playerBody.velocity = inputDirection * playerSpeed;
    }
}
