using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEnemigo1 : MonoBehaviour
{
    public float speed;
    public bool esDerecha;
    public float contadorT;
    public float tiempoParaCambiar;

    void Start()
    {
        contadorT = tiempoParaCambiar;    
    }

    void Update()
    {
        if(esDerecha==true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if(esDerecha==false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        contadorT -= Time.deltaTime;
        if(contadorT<=0)
        {
            contadorT = tiempoParaCambiar;
            esDerecha =! esDerecha;
        }
    }
}
