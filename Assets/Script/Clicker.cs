using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;

public class Clicker : MonoBehaviour
{
    public float click;
    public float timer;

    public TextMeshProUGUI textClicks;
    public TextMeshProUGUI textTimer;

    Timer timerGame;
    
    void Start()
    {
        timer = 10;
        click = Random.Range(1, 21);
        textClicks.text = "Presiona el boton: " + click.ToString() + "  veces";
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        textTimer.text = "" + timer.ToString("f0");
        Debug.Log(timer);
        if (timer > 0)
        {
            
        }
        else if (timer < 0)
        {
            timer = 0;
        }
    }

    public void Click()
    {
        
       
    }
}
