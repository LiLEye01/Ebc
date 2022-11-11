using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    SceneManagerAdmi SceneManagerAdmi;
    void Start()
    {
        SceneManagerAdmi = GetComponent<SceneManagerAdmi>();
        StartCoroutine(Change(2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Change(float tiempo)
    {
        SceneManagerAdmi.nextLevel();
        yield return new WaitForSecondsRealtime(tiempo);
        SceneManagerAdmi.ChangeScene();
    }
}
