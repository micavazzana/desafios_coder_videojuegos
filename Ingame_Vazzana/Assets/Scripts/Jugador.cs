using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidadDeMovimiento;
    void Start()
    {
    }

    void FixedUpdate()
    {
        Movimiento();
    }

    void Movimiento()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(horizontal, 0.0f, vertical);
        transform.Translate(movimiento * this.velocidadDeMovimiento * Time.deltaTime);
    }
}
