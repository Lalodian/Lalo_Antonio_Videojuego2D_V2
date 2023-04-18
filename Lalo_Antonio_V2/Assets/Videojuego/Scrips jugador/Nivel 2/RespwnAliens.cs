using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespwnAliens : MonoBehaviour
{
    [Header("Aliens 1")]
    [SerializeField] private GameObject prefapAlien1;
    [SerializeField] private float tiempoSpawnAlien1;
    [SerializeField] private float tiempoAlien1;

    void Start()
    {
        tiempoAlien1 = tiempoSpawnAlien1;
    }

    void Update()
    {
        PrefapsMunicion();
    }

    private void PrefapsMunicion()
    {
        tiempoAlien1 -= Time.deltaTime;

        if (tiempoAlien1 <= 0)
        {
            tiempoAlien1 = tiempoSpawnAlien1;
            GameObject objeto = Instantiate(prefapAlien1, new Vector2(10, -2), Quaternion.identity);
        }
    }
}
