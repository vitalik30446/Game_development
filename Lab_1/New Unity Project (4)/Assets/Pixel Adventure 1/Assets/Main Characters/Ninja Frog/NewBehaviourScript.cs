using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float speed = 0.1f;
    public Rigidbody2D physic;
    public bool isGrounded;
    private float groundRadius = 0.3f;

    public Transform groundCheck;
    public LayerMask groundMask;

    private bool cantStand;
    public bool crouching;

    private void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Input.GetAxis("Horizontal");

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);
        cantStand = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            physic.AddForce(new Vector2(0, 800)); 
        }


        if (Input.GetAxis("Horizontal") < 0 ) {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        Crouch();

        void Crouch() {
            if ((Input.GetKeyDown(KeyCode.C) || cantStand == true) && isGrounded == true)
            {
                crouching = true;
            }
            else
            {
                crouching = false;
            }
        }
    }
}
