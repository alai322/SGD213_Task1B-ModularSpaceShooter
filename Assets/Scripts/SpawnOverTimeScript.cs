using UnityEngine;
using System.Collections;

// Handles enemy spawning
public class SpawnOverTimeScript : MonoBehaviour
{
    [SerializeField]
    private GameObject spawnObject; // Object to spawn

    [SerializeField]
    private float spawnDelay = 2f;  // Time delay between spawns

    private Renderer ourRenderer;

    void Start()
    {
        ourRenderer = GetComponent<Renderer>();

        // Stop our Spawner from being visible!
        ourRenderer.enabled = false;

        // Call the given function after spawnDelay seconds, 
        // and then repeatedly call it after spawnDelay seconds.
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    void Spawn()
    {
        float x1 = transform.position.x - ourRenderer.bounds.size.x / 2;
        float x2 = transform.position.x + ourRenderer.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}
