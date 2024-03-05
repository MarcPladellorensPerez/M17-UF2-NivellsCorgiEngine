using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{
    public GameObject portal;

    void Update()
    {
        if (Moneda.monedasRecogidas >= 3) // Cambiar 3 al número deseado de monedas para activar el portal
        {
            portal.SetActive(true);
        }
        else
        {
            portal.SetActive(false);
        }
    }
}
