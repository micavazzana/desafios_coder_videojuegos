using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float range = 100;
    public Camera fpsCam;

    //FX
    public GameObject impactEffect;
    public ParticleSystem flashEffect;
    public ParticleSystem casquillosEffect;
    //Audio
    AudioSource audioSource;
    AudioClip clipDisparo;
    AudioClip clipHit;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Disparar();
        }
    }
    private void Disparar()
    {
        RaycastHit hit;
        flashEffect.Play();
        casquillosEffect.Play();

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
           if(hit.transform.tag == "Enemigo")
           {
                GameObject impacto = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impacto,3f);
           }
        }
    }

    private void AudioPlay(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
