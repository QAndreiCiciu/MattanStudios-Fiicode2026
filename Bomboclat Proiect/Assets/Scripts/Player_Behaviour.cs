using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Player_Behaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform tr;
    private int collided;
    private float moveX;
    private float jump;
    public float jumPower = 10;
    public float speed = 1;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        collided = 0;
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movement = movementValue.Get<Vector2>();

        moveX = movement.x;
    }

    private void OnJump(InputValue jumpValue)
    {
        jump = jumPower*collided;
        collided = 0;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movement = new Vector2(moveX, 0);
        tr.Translate(movement*speed*Time.deltaTime);
        rb.AddForceY(jump, ForceMode2D.Impulse);
        jump = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collided = 1;
    }
}
