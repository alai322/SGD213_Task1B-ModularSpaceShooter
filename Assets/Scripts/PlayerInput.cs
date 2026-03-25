using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Handles player input
public class PlayerInput : MonoBehaviour
{
    private PlayerMovementScript playerMovementScript;
    private ShootingScript shootingScript;

    void Start()
    {   
        playerMovementScript = GetComponent<PlayerMovementScript>();
        shootingScript = GetComponent<ShootingScript>();
    }

    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float CurrentTime = Time.time;

        // Control player horizontal movmement
        if (HorizontalInput != 0.0f)
        {
            playerMovementScript.MovePlayer(HorizontalInput);
        }

        // Control player shooting
        if (Input.GetButton("Fire1"))
        {
            shootingScript.Shoot(CurrentTime);
        }
    }
}
