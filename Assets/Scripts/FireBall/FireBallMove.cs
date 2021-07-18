using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMove : MonoBehaviour
{
    Vector3 moveDirection;
    float moveSpeed = 5.0f;
    Rigidbody fireBallBody;

    void Start()
    {
        fireBallBody = this.gameObject.GetComponent<Rigidbody>();
        moveDirection = new Vector3(-1, 0, 0);
        fireBallBody.velocity = moveDirection * moveSpeed;
    }
}
