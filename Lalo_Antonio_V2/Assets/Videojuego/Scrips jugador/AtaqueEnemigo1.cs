using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigo1 : MonoBehaviour
{
    [Header("Datos De Enemigo")]
    [SerializeField] private float speedEnemy;
    void Update()
    {
        transform.position = Vector3.left * speedEnemy * Time.deltaTime + transform.position;
    }
}
