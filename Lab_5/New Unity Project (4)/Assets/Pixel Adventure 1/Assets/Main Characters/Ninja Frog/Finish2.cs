using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish2 : MonoBehaviour
{ 

private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject == Player.Instance.gameObject)
    {
        Player.Instance.Finish2();
    }
}
}