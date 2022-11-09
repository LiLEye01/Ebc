using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonPush : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textRevision;

    public string[] decition;
    
    int index;

    void Start()
    {
        index=Random.Range(0, decition.Length);
        textRevision.text = decition[index];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckButton()
    {
        if(textRevision.text== "Presiona el boton")
        {
            //ganaste
        }
        else
        {
            //perdiste
        }
    }
}
