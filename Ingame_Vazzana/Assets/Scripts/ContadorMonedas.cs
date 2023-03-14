using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorMonedas : MonoBehaviour
{
    public static int contador;

    void Start()
    {
        contador = 0;
    }
    public void Contador()
    {
        contador++;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Moneda"))
        {
            Contador();
        }
    }
}
