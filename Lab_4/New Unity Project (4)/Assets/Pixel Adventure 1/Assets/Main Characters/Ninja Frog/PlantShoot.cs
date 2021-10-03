using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantShoot : MonoBehaviour
{
    public Transform plantshotpos;
    public GameObject Bullet;

    public float fireRate = 1.8f;

    float elapsedTime = 0.0f;


    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        elapsedTime += Time.deltaTime;
        if (elapsedTime > fireRate)
        {
            elapsedTime = 0.0f;
            Instantiate(Bullet, plantshotpos.transform.position, transform.rotation);            
        }
 
    }
    
}
