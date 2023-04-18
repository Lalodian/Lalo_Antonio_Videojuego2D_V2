using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private GameObject efectoMuerte;
    [SerializeField] AudioClip clip;

    public void TomarDaño(float daño)
    {
        vida -= daño;
        if(vida <=0)
        {
            Muerte();
        }
    }
    public void Muerte()
    {
        Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colisión detectada con objeto de etiqueta: " + collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Player"))
        {
            ControladorSonido.Instance.EjecutarSonido(clip);
            GameManager.Instance.PerderVida();
            Destroy(this.gameObject);

        }
    }
}
