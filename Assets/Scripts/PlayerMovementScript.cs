using UnityEngine;
using System.Collections;

public class PlayerMovementScript : MonoBehaviour {
    // SerializeField exposes this value to the Editor, but not to other Scripts!
    // It is "pseudo public"
    // HorizontalPlayerAcceleration indicates how fast we accelerate Horizontally
    [SerializeField]
    private float f_horPlayAccel = 5000f;

    private Rigidbody2D ourRigidbody;

    // Use to initialise rigidbody
    void Start() 
    {
        ourRigidbody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    public void MovePlayer(float HorizontalInput)
    {
        if (HorizontalInput != 0.0f) {
            Vector2 ForceToAdd = Vector2.right * HorizontalInput * f_horPlayAccel * Time.deltaTime;
            ourRigidbody.AddForce(ForceToAdd);
        } 
    }

   
}   
