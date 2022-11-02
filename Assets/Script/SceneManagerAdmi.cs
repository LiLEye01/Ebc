using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerAdmi : MonoBehaviour
{
    public GameObject Panel;

    int numRandom;
    int activeScene;

    public void ChangeScene(string SceneName)
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(numRandom);
    }

    public void nextLevel()
    {
        numRandom = Random.Range(1, 5);
        activeScene=SceneManager.GetActiveScene().buildIndex;
        while (numRandom == activeScene)
        {
            int nRandom=Random.Range(1, 5);
            numRandom = nRandom;
        }
        
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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