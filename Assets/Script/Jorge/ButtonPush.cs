using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonPush : MonoBehaviour
{
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
        gameManager = GetComponent<GameManager>();
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
        
        if (timer == 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }

    public void CheckButton()
    {
        if(textRevision.text == "Presiona el boton" && timer > 0)
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
