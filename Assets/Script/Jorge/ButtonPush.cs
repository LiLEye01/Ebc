using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonPush : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;
    [SerializeField]
    TextMeshProUGUI textRevision;
    [SerializeField]
    TextMeshProUGUI textTimer;

    GameManager gameManager;

    public string[] decition;
    
    int index;
    public float timer;

    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
        index=Random.Range(0, decition.Length);
        textRevision.text = decition[index];
        
    }

    // Update is called once per frame
    void Update()
    {
        textTimer.text = "" + timer.ToString("f0");
        timer -= 1 * Time.deltaTime;
        if (timer < 1)
        {
            timer = 0;
        }
        Debug.Log(timer);
        
        if (timer == 0 && index == 0)
        {
            //gameManager.MinijuegoPerdido();
            SceneManager.LoadScene("Defeat");
            ControladorPuntos.Instance.ReiniciarPuntos(cantidadPuntos);
           
        }

        if (timer == 0 && index == 1)
        {
            //ganaste
            SceneManager.LoadScene("Win");
            ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
            ControladorPuntos.Instance.WinCondition();
        }
    }

    public void CheckButton()
    {
        if(index == 0 && timer > 0)
        {
            Debug.Log("Win");
            ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
            SceneManager.LoadScene("Win");
        }
        if (index == 1 && timer > 0)
        {
            //perdiste
            SceneManager.LoadScene("Defeat");
            ControladorPuntos.Instance.ReiniciarPuntos(cantidadPuntos);
        }


    }
}
