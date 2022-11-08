using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColitionDetecter : MonoBehaviour
{
    public SceneManagerAdmi sceneManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Toque");
            sceneManager.ChangeScene(); ;
            Debug.Log(sceneManager.numRandom);

        }
    }
}
