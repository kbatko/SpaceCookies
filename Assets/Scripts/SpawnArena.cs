using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnArena : MonoBehaviour {

    // Variable to store the enemy prefab
    public GameObject enemy;

    // Szybkosc generowania komet
    public float spawnTime = 2;

    private float nextActionTime = 0.0f;
    public float period = 10f;
    public int ADDITIONAL_COMETS = 0;
    public int MAX_COMETS = 5;

    // Use this for initialization
    void Start () {

        // Call the 'addEnemy' function in 0 second
        // Then every 'spawnTime' seconds
 
        InvokeRepeating("addEnemy", 0, spawnTime);
	}
	
    void addEnemy ()
    {
        float radius = 20;

        Vector2 spawnPoint;
        float theta = (Random.value * 2 * Mathf.PI);
        spawnPoint.x = radius * Mathf.Cos(theta);
        spawnPoint.y = radius * Mathf.Sin(theta);

        Instantiate(enemy, spawnPoint, Quaternion.identity);
    }

	// Update is called once per frame
	void Update () {
        if (Time.time > nextActionTime)
        {
            
            
            nextActionTime += period;
            spawnTime *= 0.75f;
            InvokeRepeating("addEnemy", 0, spawnTime);
            // execute block of code here
        }
    }
}
