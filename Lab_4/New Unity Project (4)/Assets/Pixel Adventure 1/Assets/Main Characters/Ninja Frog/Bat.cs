using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    public int lives = 1;

    public float speed;

    public int positionOfPatrol;
    public Transform point;

    bool moveRight;

    Transform player;
    public float stoppingDistance;

    bool patrol = false;
    bool angry = false;
    bool goBack = false;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {

        if (Vector2.Distance(transform.position, point.position) < positionOfPatrol)
        {
            patrol = true;
        }

        if (Vector2.Distance(transform.position, player.position) < stoppingDistance)
        {
            angry = true;
        }

        if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
        {
            goBack = true;
        }

        if (patrol == true)
        {
            Patrol();
        }

        else if (goBack == true)
        {
            GoBack();
        }
    }

    void Patrol()
    {
        if (transform.position.x > point.position.x + positionOfPatrol)
        {
            moveRight = false;
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (transform.position.x < point.position.x - positionOfPatrol)
        {
            moveRight = true;
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }

    void GoBack()
    {
        transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
    }

}


