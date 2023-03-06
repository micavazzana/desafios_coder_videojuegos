using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject granada;
    public float range;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            LanzarGranada();
        }    }

    private void LanzarGranada()
    {
        GameObject instanciaGranada = Instantiate(granada,spawnPoint.position, spawnPoint.rotation);
        instanciaGranada.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * range, ForceMode.Impulse);
    }
}
