using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    public Life Life;
    void Start()
    {
        Life = gameObject.GetComponent<Life>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Life.lifes > 1)
        {
            SceneManager.LoadScene("GameOver");
        }
        else if(Life.lifes < 2)
        {

        }
    }
}
