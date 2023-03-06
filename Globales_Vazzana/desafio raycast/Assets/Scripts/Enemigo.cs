using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public GameObject player;
    public LayerMask playerLayer;
    public float velocidadDeMovimiento;
    public float rangoDeAlerta;
    bool estaAlerta;

    private void Start()
    {
        estaAlerta = false;
    }
    void FixedUpdate()
    {
        MoverPersonajeLerp(player);
    }
    public void MoverPersonajeLerp(GameObject p)
    {
        RaycastHit hit;
        Vector3 posicionJugador = new Vector3(p.transform.position.x, transform.position.y, p.transform.position.z);

        estaAlerta = Physics.Raycast(transform.position, transform.forward, out hit, rangoDeAlerta, playerLayer);
        if (estaAlerta && hit.transform.tag == "Jugador")
        {
            transform.LookAt(posicionJugador);
            //transform.position = Vector3.Lerp(transform.position, posicionJugador, Time.deltaTime * velocidadDeMovimiento);
        }
    }
}
