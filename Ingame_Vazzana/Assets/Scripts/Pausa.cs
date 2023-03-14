using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    private bool estaPausado;
    public GameObject menuPausa;
    public GameObject menuHud;

    void Start()
    {
        this.estaPausado = false;
    }

    void Update()
    {
        TogglePausa();
    }

    void TogglePausa()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(estaPausado)
            {
                ResumeGame();
            }
            else 
            {               
                PausarJuego();
            }
        }
    }

    void ResumeGame()
    {
        this.estaPausado = false;
        menuPausa.SetActive(false);
        menuHud.SetActive(true);
        Time.timeScale = 1.0f;
    }

    void PausarJuego()
    {
        this.estaPausado = true;
        menuPausa.SetActive(true);
        menuHud.SetActive(false);
        Time.timeScale = 0;
    }
}
