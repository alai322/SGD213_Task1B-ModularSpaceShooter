using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovementScript playerMovementScript;

    void Start()
    {   
        playerMovementScript = GetComponent<PlayerMovementScript>();
    }

    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if(HorizontalInput != 0.0f)
        {
            playerMovementScript.MovePlayer(HorizontalInput);
        }
    }
}
