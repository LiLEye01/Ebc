using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager1 : MonoBehaviour
{
    public GameObject[] Vida;
    private int life;
    private float puntos;
    private TextMeshProUGUI textMesh;

	private void Start()
	{
        life = Vida.Length;
        textMesh = GetComponent<TextMeshProUGUI>();

    }
	private void Update()
    {
        if (life < 1)
        {
            Destroy(Vida[0].gameObject);
            SceneManager.LoadScene("Lose");
        }
        else if (life < 2)
        {
            Destroy(Vida[1].gameObject);
        }
        else if (life < 3)
        {
            Destroy(Vida[2].gameObject);
        }
        puntos += Time.deltaTime;
        textMesh.text = puntos.ToString("0");  
    }
    public void SumarPuntos(float puntosEntrada) 
    {
        puntos += puntosEntrada;
    }
}
