using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Heal : MonoBehaviour
{
    private int lives = 5;
    public TMP_Text livesText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            lives += 1;
            if (lives > 5)
            {
                lives = 5;
            }
            livesText.text = lives.ToString();           
        }
    }  
}
