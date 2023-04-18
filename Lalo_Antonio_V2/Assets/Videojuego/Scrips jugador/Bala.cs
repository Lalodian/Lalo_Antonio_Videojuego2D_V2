using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float da�o;
    [SerializeField] private float tiempoDeDestruir;

    void Start()
    {
        // Destruye el objeto despu�s de 3 segundos
        Invoke("DestruirObjeto", tiempoDeDestruir);
    }

    void DestruirObjeto()
    {
        // Destruye el objeto
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colisi�n detectada con objeto de etiqueta: " + collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Enemigo")|| collision.gameObject.CompareTag("Aliens"))
        {
            collision.GetComponent<Enemigo>().TomarDa�o(da�o);
            Destroy(gameObject);
        }
    }

}
