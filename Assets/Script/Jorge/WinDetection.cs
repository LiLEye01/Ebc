using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinDetection : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Win");
             ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
            Debug.Log("Win");
        }
    }
}
