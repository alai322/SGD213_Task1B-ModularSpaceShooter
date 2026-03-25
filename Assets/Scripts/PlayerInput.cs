using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

        if (HorizontalInput != 0.0f)
        {
            playerMovementScript.MovePlayer(HorizontalInput);
        }

        if (Input.GetButton("Fire1"))
        {
            shootingScript.Shoot(CurrentTime);
        }
    }
}
