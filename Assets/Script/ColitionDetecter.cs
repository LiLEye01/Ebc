using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColitionDetecter : MonoBehaviour
{

    void Start()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Toque");
            SceneManager.LoadScene("Lose");
        }
    }
}
