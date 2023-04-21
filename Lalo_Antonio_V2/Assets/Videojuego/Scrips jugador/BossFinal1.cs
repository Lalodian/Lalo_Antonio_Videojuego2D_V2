using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossFinal1 : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    public float minDistanceToPlayer = 5f;

    public string Nombre;

    [SerializeField] private float vida;
    [SerializeField] private GameObject efectoMuerte;

    [SerializeField] AudioClip clip;
    [SerializeField] AudioClip clipexplocion;

    private Rigidbody2D rb;
    private bool isActivated = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

            if (isActivated)
            {
                Vector2 direction = (Vector2)player.position - rb.position;
                direction.Normalize();
                rb.velocity = direction * moveSpeed;
            }
            else
            {
                // Si el enemigo ya no está activado, detener su movimiento
                rb.velocity = Vector2.zero;
            }

    }

    void Update()
    {
        if (!isActivated && Vector2.Distance(transform.position, player.position) <= minDistanceToPlayer)
        {
            isActivated = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            ControladorSonido.Instance.EjecutarSonido(clip);
            GameManager.Instance.PerderVida();
        }
    }

    public void TomarDaño(float daño)
    {
        vida -= daño;
        if (vida <= 0)
        {
            Muerte();
        }
    }

    public void Muerte()
    {
        // Desactiva la variable isActivated
        isActivated = false;
        moveSpeed = 0;

        Instantiate(efectoMuerte, transform.position, Quaternion.identity);

        EjecutarExplosionYSiguienteEscena(3f); // espera 1 segundo antes de cambiar de escena
    }

    public void EjecutarExplosionYSiguienteEscena(float duracion)
    {
        Debug.Log("Audio explocion");
        ControladorSonido.Instance.EjecutarSonido(clipexplocion);
        StartCoroutine(EsperarAntesDeCambiarEscena(duracion)); // espera 'duracion' segundos antes de cambiar de escena
    }

    public IEnumerator EsperarAntesDeCambiarEscena(float duracion)
    {
        yield return new WaitForSeconds(duracion);
        SceneManager.LoadScene(Nombre);
    }
}
