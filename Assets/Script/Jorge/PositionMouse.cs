using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionMouse : MonoBehaviour
{
    Camera cam;
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = (Vector2)cam.ScreenToWorldPoint(Input.mousePosition);
    }
}
