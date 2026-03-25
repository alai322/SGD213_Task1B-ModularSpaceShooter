using UnityEngine;
using System.Collections;

// Handles bullets and cooldown
public class ShootingScript : MonoBehaviour
{
    [SerializeField] 
    private GameObject bullet;
    
    [SerializeField] 
    private float fireDelay = 1f;

    private float lastFiredTime = 0f;
    private float bulletOffset = 2f;

    void Start()
    {
        // Spawn bullets in front of player
        bulletOffset = 
        GetComponent<Renderer>().bounds.size.y / 2 + // Half of our size
        bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size
    }

    public void Shoot(float CurrentTime) 
    {
        if (CurrentTime - lastFiredTime > fireDelay)
        {
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);
            Instantiate(bullet, spawnPosition, transform.rotation);
            lastFiredTime = CurrentTime;
        }
    }
}
