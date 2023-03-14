using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Text puntaje;

    void Start()
    {
       
    }

    
    void Update()
    {
        puntaje.text = $"{ContadorMonedas.contador}";
    }
}
