using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespwnAliens : MonoBehaviour
{
    [Header("Aliens 1")]
    [SerializeField] private List<GameObject> prefapAliens1 = new List<GameObject>();
    [SerializeField] private Transform cordenadas;
    [SerializeField] private float tiempoSpawnAlien1;
    [SerializeField] private float tiempoAlien1;

    [Header("Aliens 1")]
    [SerializeField] private List<GameObject> prefapAliens2 = new List<GameObject>();
    [SerializeField] private float tiempoSpawnAlien2;
    [SerializeField] private float tiempoAlien2;


    void Start()
    {
        tiempoAlien1 = tiempoSpawnAlien1;
        tiempoAlien2 = tiempoSpawnAlien2;
    }

    void Update()
    {
        PrefapsAliens1();
        PrefapsAliens2();
    }

    private void PrefapsAliens1()
    {
        tiempoAlien1 -= Time.deltaTime;

        if (tiempoAlien1 <= 0)
        {
            tiempoAlien1 = tiempoSpawnAlien1;
            int indexMunicion = Random.Range(0, prefapAliens1.Count);
            GameObject objeto = Instantiate(prefapAliens1[indexMunicion], cordenadas.position, Quaternion.identity);
        }
    }

    private void PrefapsAliens2()
    {
        tiempoAlien2 -= Time.deltaTime;

        if (tiempoAlien2 <= 0)
        {
            tiempoAlien2 = tiempoSpawnAlien2;
            int indexMunicion = Random.Range(0, prefapAliens2.Count);
            GameObject objeto = Instantiate(prefapAliens2[indexMunicion], cordenadas.position, Quaternion.identity);
        }
    }
}
