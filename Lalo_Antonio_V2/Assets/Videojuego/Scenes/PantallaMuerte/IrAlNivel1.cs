using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IrAlNivel1 : MonoBehaviour
{
    public string nombreDeEscena;
    public void CambiarEscena()
    {
        SceneManager.LoadScene(nombreDeEscena);
    }
}
