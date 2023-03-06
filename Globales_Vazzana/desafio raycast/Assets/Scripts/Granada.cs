using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Granada : MonoBehaviour
{
    public GameObject efectoExplosion;
    public float delay = 3f;
    public float radius = 20f;
    public float explosionForce = 10f;

    void Start()
    {
        Invoke("ExplotarGranada",delay);
    }
    void ExplotarGranada()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider item in colliders)
        {
            Rigidbody rb = item.GetComponent<Rigidbody>();
            if(rb != null)
                rb.AddExplosionForce(explosionForce,transform.position, radius, 1f, ForceMode.Impulse);
        }
        Instantiate(efectoExplosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
