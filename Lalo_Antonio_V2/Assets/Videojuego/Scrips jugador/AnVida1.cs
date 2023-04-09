using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnVida1 : MonoBehaviour
{
    [SerializeField] AudioClip clip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            bool vidaRecuperada = GameManager.Instance.RecuperarVida();
            ControladorSonido.Instance.EjecutarSonido(clip);
            if (vidaRecuperada)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
