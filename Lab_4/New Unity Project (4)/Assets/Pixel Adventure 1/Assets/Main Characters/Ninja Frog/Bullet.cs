using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    public float fireRate = 3f;

    float elapsedTime = 0.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > fireRate)
        {
            elapsedTime = 0.0f;
            Destroy(this.gameObject);
        }

        if (transform.position.y < -30)
        {
            Destroy(this.gameObject);
        }
    }
    
}