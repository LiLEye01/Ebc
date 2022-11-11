using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonPush : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI textRevision;

    GameManager gameManager;

    public string[] decition;
    
    int index;

    void Start()
    {
        gameManager = GetComponent<GameManager>();
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
            Debug.Log("Win");
            //gameManager.SumarPuntos(50);
            SceneManager.LoadScene("Win");
        }
        else if(textRevision.text== "NO presiones el boton")
        {
            //perdiste
            SceneManager.LoadScene("Lose");
        }
    }
}
