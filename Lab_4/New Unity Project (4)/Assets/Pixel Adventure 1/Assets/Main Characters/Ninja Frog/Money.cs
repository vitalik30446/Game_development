using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    private int coins = 0;
    public TMP_Text coinsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            coins += 1;
            coinsText.text = coins.ToString(); 
        }
    }
}
