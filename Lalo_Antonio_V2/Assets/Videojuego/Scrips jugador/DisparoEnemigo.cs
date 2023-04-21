using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigo : MonoBehaviour
{
    public Transform player;
    public GameObject bulletPrefab;
    public float fireRate = 2f; // La cantidad de veces por segundo que disparará
    public float bulletSpeed = 10f; // Velocidad del proyectil
    public float bulletLifetime = 2f; // Tiempo de vida del proyectil

    //Cuanto tiempo tardara en Respawnear la siente esfera
    public float tiempoDeRespawn;
    //Lo mismo pero para programar
    private float tiempo;

    private Rigidbody2D rb;
    private GameObject bullet;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tiempo = tiempoDeRespawn;
    }

    void FixedUpdate()
    {
        if (bullet == null && tiempo >= tiempoDeRespawn)
        {
            Fire();
            tiempo = 0f;
        }
        tiempo += Time.deltaTime;
    }

    void Fire()
    {
        Vector2 direction = (Vector2)player.position - rb.position;
        direction.Normalize();
        bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        Destroy(bullet, bulletLifetime);
    }
}
