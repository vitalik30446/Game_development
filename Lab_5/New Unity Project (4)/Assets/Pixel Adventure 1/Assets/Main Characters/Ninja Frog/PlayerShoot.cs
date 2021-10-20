using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform playershotpos;
    public GameObject PlayerBullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(PlayerBullet, playershotpos.transform.position, transform.rotation);
        }
    }
}
