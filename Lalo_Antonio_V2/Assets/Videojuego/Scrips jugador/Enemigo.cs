using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private GameObject efectoMuerte;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.PerderVida();
            Destroy(this.gameObject);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.PerderVida();
            Destroy(this.gameObject);

        }
    }
}
