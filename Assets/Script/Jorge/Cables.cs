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
            ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
            SceneManager.LoadScene("Win");
        }
        else if(Input.GetMouseButton(0) && !collision.CompareTag(tagsCables[index]))
        {
            //fallo
           
        }
    }

    void Update()
    {
        
    }
}
