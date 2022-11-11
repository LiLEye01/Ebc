using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour
{
    public GameObject[] hearts;
    private int life = 3;

    private void Start()
    {
        life = hearts.Length;
    }
    private void Awake()
    {
        if (life < 1) 
        {
            Destroy(hearts[0].gameObject);
            SceneManager.LoadScene("Lose");
        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(hearts[2].gameObject); 
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            life -= 1;
        }
    }
}
