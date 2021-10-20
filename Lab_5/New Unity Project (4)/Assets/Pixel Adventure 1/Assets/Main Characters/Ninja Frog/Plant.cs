using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public int lives = 1;

    public float speed;
    public Rigidbody2D physic;
    public bool isGrounded;
    private float groundRadius = 0.3f;
    public Transform groundCheck;
    public LayerMask groundMask;
    private bool cantStand;


    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);
        cantStand = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);
  
    }
}
