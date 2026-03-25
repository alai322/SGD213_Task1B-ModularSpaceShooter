using UnityEngine;
using System.Collections;

// Handles bullet speed movement
public class BulletMoveForward : MonoBehaviour 
{
    private float acceleration = 50f;
    private float initialVelocity = 5f;

    private Rigidbody2D ourRigidbody;

    void Start()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
        ourRigidbody.velocity = Vector2.up * initialVelocity;
    }

    void Update()
    {
        Vector2 ForceToAdd = Vector2.up * acceleration * Time.deltaTime;
        ourRigidbody.AddForce(ForceToAdd);
    }
}
