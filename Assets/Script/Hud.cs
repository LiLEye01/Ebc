using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hud : MonoBehaviour
{
    public TextMeshProUGUI puntos;

    public void Update()
    {
        puntos.text = GameManager.Instance.PuntosTotales.ToString();
    }
}
