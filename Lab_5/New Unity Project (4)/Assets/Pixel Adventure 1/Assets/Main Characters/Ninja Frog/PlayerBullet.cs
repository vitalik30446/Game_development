using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
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
            Destroy(GameObject.FindWithTag("PlayerShoot"));
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Block") || collision.CompareTag("Trap"))
        {
            Destroy(this.gameObject);
        }
        if (collision.CompareTag("Enemy"))
        {
            Destroy(GameObject.FindWithTag("Enemy"));
            Destroy(this.gameObject);
        }
    }
}
