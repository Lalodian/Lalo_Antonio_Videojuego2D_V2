using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nivel : MonoBehaviour
{
    public string nombreDeEscena;
    public void CambiarEscena()
    {
        SceneManager.LoadScene(nombreDeEscena);
    }
}
