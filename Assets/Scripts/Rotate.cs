using UnityEngine;
using System.Collections;

// Randomises sprite rotation
public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float maximumSpinSpeed = 200; // rotate speed

    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.Range(-maximumSpinSpeed, maximumSpinSpeed);
    }
}
