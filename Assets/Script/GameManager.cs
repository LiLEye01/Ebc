using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject[] hearts;
    private int life = 3;
    public static GameManager Instance { get; private set; }
    public int PuntosTotales { get { return puntosTotales; } }
    private int puntosTotales;

    private void Start()
    {
        life = hearts.Length;
    }
    private void Update()
    {
        if (life < 1)
        {
            hearts[0].SetActive(false);
            SceneManager.LoadScene("Lose");
        }
        else if (life < 2)
        {
            hearts[1].SetActive(false);
        }
        else if (life < 3)
        {
            hearts[2].SetActive(false);
        }


    }
    public void MinijuegoPerdido()
    {
        life--;
    }
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
