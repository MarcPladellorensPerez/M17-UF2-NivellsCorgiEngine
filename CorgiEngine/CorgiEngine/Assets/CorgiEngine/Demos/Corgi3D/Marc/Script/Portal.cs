using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public GameObject portal;
    private int monedasRecogidas = 0;
    private int totalMonedas = 3; // Cambiar al número deseado de monedas para activar el portal

    public void AddCoin()
    {
        monedasRecogidas++;
        CheckMonedasRecogidas();
    }

    void CheckMonedasRecogidas()
    {
        if (monedasRecogidas >= totalMonedas)
        {
            portal.SetActive(true);
        }
    }

    void Start()
    {
        portal.SetActive(false); // Ocultar el portal al inicio
    }
}
