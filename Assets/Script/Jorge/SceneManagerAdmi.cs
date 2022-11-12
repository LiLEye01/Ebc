using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerAdmi : MonoBehaviour
{
    public GameObject Panel;

    public int numRandom;
    int activeScene;

    public void ChangeScene()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(numRandom);
    }

    public void nextLevel()
    {
        numRandom = Random.Range(3, 7);
        activeScene = SceneManager.GetActiveScene().buildIndex;
       
        while (numRandom == activeScene)
        {
            Debug.Log("Entre while");
            int nRandom = Random.Range(1, 6);
            numRandom = nRandom;
        }


        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ControlPanel()
    {
        Panel.SetActive(true);
    }

    public void ControlPanelExit()
    {
        Panel.SetActive(false);
    }


    public void ExitScene(string SceneName)
    {
        Application.Quit();
    }

   
} 