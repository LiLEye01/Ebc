using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Cables : MonoBehaviour
{
    public string[] tagsCables;

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
        }
        else if(Input.GetMouseButton(0) && !collision.CompareTag(tagsCables[index]))
        {
            //fallo
            SceneManager.LoadScene("Lose");
        }
    }
    void Update()
    {
        
    }
}
