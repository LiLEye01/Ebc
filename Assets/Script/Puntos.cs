using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    public static Puntos Instance;
    [SerializeField] private float cantidadPuntos;


    private void Awake()
    {
        if (Puntos.Instance == null)
        {
            Puntos.Instance = this;
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
}
