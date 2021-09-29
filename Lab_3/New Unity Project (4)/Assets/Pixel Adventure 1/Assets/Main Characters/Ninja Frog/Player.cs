using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public TMP_Text livesText;
    public int lives = 5;

    public float speed = 0.1f;
    public Rigidbody2D physic;
    public bool isGrounded;
    private float groundRadius = 0.3f;
    public Transform groundCheck;
    public LayerMask groundMask;
    private bool cantStand;
    public static Player Instance { get; set; }
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {

        transform.position += new Vector3(speed, 0, 0) * Input.GetAxis("Horizontal");

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);
        cantStand = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);

        if (((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && isGrounded == true))
        {
            physic.AddForce(new Vector2(0, 800));
        }


        if (Input.GetAxis("Horizontal") < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

    }
    
    private void Awake()
    {
        Instance = this;
    }
    public void GetDamage()
    {
        lives -= 1;
        livesText.text = lives.ToString();
        anim.SetTrigger("Hurt");
        transform.position = new Vector3(-15, -1, 0);
        if (lives < 1)
        {
            Destroy(this.gameObject);
        }
    }
    public void Finish()
    {
        transform.position = new Vector3(60, -5, 0);
    }
}