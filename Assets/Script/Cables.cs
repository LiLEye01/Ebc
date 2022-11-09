using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
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
        textCables.text = ("");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetMouseButton(0) && collision.CompareTag(tagsCables[index]))
        {
            //exito
        }
        else if(Input.GetMouseButton(1) && !collision.CompareTag(tagsCables[index]))
        {
            //fallo
        }
    }
    void Update()
    {
        
    }
}
