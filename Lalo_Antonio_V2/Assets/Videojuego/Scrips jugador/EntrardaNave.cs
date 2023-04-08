using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntrardaNave : MonoBehaviour
{
    public string Nivel2;

    //Se encarga de Eliminar al personaje si cae o si no los peteoritos 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(Nivel2);
        }
    }
}
