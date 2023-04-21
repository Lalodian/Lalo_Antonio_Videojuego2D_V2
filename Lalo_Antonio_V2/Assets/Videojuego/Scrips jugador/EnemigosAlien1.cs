using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigosAlien1 : MonoBehaviour
{
    public float velocidad = 5f;
    public float tiempoDeMovimiento = 2f;
    public Transform puntoIzquierda;
    public Transform puntoDerecha;
    public LayerMask capaDePlataforma;

    private Rigidbody2D rb;
    private float tiempoDeCambio;
    private bool moviendoseHaciaLaDerecha = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tiempoDeCambio = tiempoDeMovimiento;
    }

    void FixedUpdate()
    {
        bool enPlataformaIzquierda = Physics2D.OverlapCircle(puntoIzquierda.position, 0.2f, capaDePlataforma);
        bool enPlataformaDerecha = Physics2D.OverlapCircle(puntoDerecha.position, 0.2f, capaDePlataforma);

        if (enPlataformaIzquierda && !moviendoseHaciaLaDerecha)
        {
            CambiarDireccion();
        }
        else if (enPlataformaDerecha && moviendoseHaciaLaDerecha)
        {
            CambiarDireccion();
        }

        if (moviendoseHaciaLaDerecha)
        {
            rb.velocity = new Vector2(velocidad, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(-velocidad, rb.velocity.y);
        }

        tiempoDeCambio -= Time.fixedDeltaTime;
        if (tiempoDeCambio <= 0)
        {
            CambiarDireccion();
        }
    }

    void CambiarDireccion()
    {
        moviendoseHaciaLaDerecha = !moviendoseHaciaLaDerecha;
        tiempoDeCambio = tiempoDeMovimiento;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(puntoIzquierda.position, 0.2f);
        Gizmos.DrawWireSphere(puntoDerecha.position, 0.2f);
    }
}
