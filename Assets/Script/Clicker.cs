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
        timer = Random.Range(0, 21);
        timer += click;
        timerGame = GetComponent<Timer>();
        click = Random.Range(0, 21);
        textClicks.text = "Presiona el boton: " + click.ToString() + " estas veces";
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        textTimer.text = "" + timer.ToString("f0");
        Debug.Log(timer);
    }

    public void Click()
    {
        
        if (timer > 0.0f)
        {
            click--;
        }
        else if (timer < 0.0f)
        {
            timer = 0.0f;
        }
    }
}
