using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorPuntos : MonoBehaviour
{
    public static ControladorPuntos Instance;

    [SerializeField] public float cantidadPuntos;

    private void Awake()
    {
        if (ControladorPuntos.Instance == null)
        {
            ControladorPuntos.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarPuntos(float puntos)
    {
        cantidadPuntos += puntos;
    }

    public void ReiniciarPuntos(float puntos)
    {
        cantidadPuntos = 0;
    }
    public void WinCondition()
    {
        if (cantidadPuntos >= 2000)
        {
           SceneManager.LoadScene("Victory");
        }
    }
}
