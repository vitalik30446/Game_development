using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    private int coins;
    public TMP_Text coinsText;

    void Start()
    {
        coins = PlayerPrefs.GetInt("coins", coins);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            PlayerPrefs.GetInt("coins", coins);
            coins++;
            coinsText.text = coins.ToString();
        }

    }
}
