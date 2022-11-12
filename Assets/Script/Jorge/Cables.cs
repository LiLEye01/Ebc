using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Cables : MonoBehaviour
{
    public string[] tagsCables;
   [SerializeField] private float cantidadPuntos;

    [SerializeField]
    TextMeshProUGUI textCables;

    int index;
    void Start()
    {
        index = Random.Range(0,tagsCables.Length);
        textCables.text = ("Corta el cable: " + tagsCables[index]);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButton(0) && collision.CompareTag(tagsCables[index]))
        {
            //exito
            
            SceneManager.LoadScene("Win");
            ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
        }
        else if(Input.GetMouseButton(0) && !collision.CompareTag(tagsCables[index]))
        {
            //fallo
            SceneManager.LoadScene("Defeat");
            ControladorPuntos.Instance.ReiniciarPuntos(cantidadPuntos);
        }
    }

    void Update()
    {
        
    }
}
