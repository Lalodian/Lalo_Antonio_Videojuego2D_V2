using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuerteRapida : MonoBehaviour
{
    public float tiempoDeVida = 120f; // tiempo que durar� el objeto antes de destruirse

    void Start()
    {
        // Destruye el objeto despu�s de 'tiempoDeVida' segundos
        Destroy(gameObject, tiempoDeVida);
    }
}
