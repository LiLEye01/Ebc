using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DetectaCosas : MonoBehaviour
{
    bool tornillos = false;
    [SerializeField] private float cantidadPuntos;
    bool resistencias = false;
    bool led = false;

    public TextMeshProUGUI textInstructions;
    public TextMeshProUGUI textTimer;

    public float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textTimer.text = "" + timer.ToString("f0");
        textInstructions.text = "Arrastra los objetos dentro de la otra caja";
        timer -= 1 * Time.deltaTime;
        if (timer < 1)
        {
            SceneManager.LoadScene("Lose");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("tornillos"))
        {
            tornillos = true;
            Debug.Log("T");
        }
        else if (collision.CompareTag("resistencias"))
        {
            resistencias = true;
            Debug.Log("R");
        }
        else if (collision.CompareTag("led"))
        {
            led = true;
            Debug.Log("L");
        }

        if(tornillos == true && resistencias == true && led == true)
        {
            SceneManager.LoadScene("Win");
            ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
        }
    }
    
}
