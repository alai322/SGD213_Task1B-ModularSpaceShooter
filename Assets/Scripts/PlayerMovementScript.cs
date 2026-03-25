using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
    // SerializeField exposes this value to the Editor, but not to other Scripts! It is "pseudo public"
    [SerializeField] private float f_horPlayAccel = 5000f;

    private Rigidbody2D ourRigidbody;

    void Start() 
    {
        ourRigidbody = GetComponent<Rigidbody2D>(); 
    }

    public void MovePlayer(float HorizontalInput)
    {
        if (HorizontalInput != 0.0f) {
            Vector2 ForceToAdd = Vector2.right * HorizontalInput * f_horPlayAccel * Time.deltaTime;
            ourRigidbody.AddForce(ForceToAdd);
        } 
    } 
}   
