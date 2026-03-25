using UnityEngine;
using System.Collections;

// Handles linear enemy movement
public class EnemyMoveForward : MonoBehaviour 
{
    private float acceleration = 75f; // enemy speed
    private float initialVelocity = 2f; // starting enemy speed
    private Rigidbody2D ourRigidbody;

    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
        ourRigidbody.velocity = Vector2.down * initialVelocity;
    }

    void Update()
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }
}
