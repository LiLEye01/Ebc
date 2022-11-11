using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int PuntosTotales { get { return puntosTotales; } }
    private int puntosTotales;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Más de un Game Manager en escena");
        }
    }
    public void SumarPuntos(int PuntosASumar)
    {
        puntosTotales += PuntosASumar;
    }
}
