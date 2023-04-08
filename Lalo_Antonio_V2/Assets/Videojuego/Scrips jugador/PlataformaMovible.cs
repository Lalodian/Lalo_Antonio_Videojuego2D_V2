using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovible : MonoBehaviour
{
    public GameObject plataforma;
    public float vel;
    public Transform puntoActual;
    public Transform[] points;
    public int puntoSeleccionado;
    void Start()
    {
        puntoActual = points[puntoSeleccionado];
    }


    void Update()
    {
        plataforma.transform.position = Vector3.MoveTowards(
            plataforma.transform.position,
            puntoActual.position,
            Time.deltaTime * vel);
            if (plataforma.transform.position == puntoActual.position)
            {
                puntoSeleccionado += 1;
                if (puntoSeleccionado == points.Length)
                {
                puntoSeleccionado = 0;
                }
            }
        puntoActual = points[puntoSeleccionado];
    }
}
