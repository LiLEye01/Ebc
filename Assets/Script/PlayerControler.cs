using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private PlayerControls playerActions;

    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float jump = 5f;

    private void Awake()
    {
        playerActions = new PlayerControls();
    }
    void Start()
    {
        playerActions.Enable();
    }

    private void OnEnable()
    {
        playerActions.Disable();   
    }

    private void OnDisable()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //read the value
       float movemetInput = playerActions.Player.Movement.ReadValue<float>();

        //movement player
        Vector3 currentPosition = transform.position;
        currentPosition.x += movemetInput * speed * Time.deltaTime;
        transform.position = currentPosition;
    }
}
