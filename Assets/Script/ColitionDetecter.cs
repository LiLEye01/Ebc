using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColitionDetecter : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Toque");

            SceneManager.LoadScene("Lose");

        }
        else if (collision.gameObject.CompareTag("Win"))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
