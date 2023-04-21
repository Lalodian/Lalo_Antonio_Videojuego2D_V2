using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaBabosa : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            ControladorSonido.Instance.EjecutarSonido(clip);
            GameManager.Instance.PerderVida();
            Destroy(this.gameObject);

        }
    }
}
