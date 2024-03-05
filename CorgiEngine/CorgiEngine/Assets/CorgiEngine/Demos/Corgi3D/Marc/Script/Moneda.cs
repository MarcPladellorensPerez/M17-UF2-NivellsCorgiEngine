using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public static int monedasRecogidas = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gameObject.CompareTag("Coin"))
        {
            monedasRecogidas++;
        }
    }
}
