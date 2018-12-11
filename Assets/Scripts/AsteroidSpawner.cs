using UnityEngine;


public class AsteroidSpawner : MonoBehaviour {

    public float kat;

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
 
        //InvokeRepeating("addEnemy", 0, spawnTime);
    }
	
    void addEnemy ()
    {
        //print("Ayaia, I'm youe little butterfly");
        float radius = 20;

        Vector2 spawnPoint;
        float theta = (Random.value * 2 * Mathf.PI);
        spawnPoint.x = radius * Mathf.Cos(theta);
        spawnPoint.y = radius * Mathf.Sin(theta);

        GameObject asteroid = Instantiate(enemy, spawnPoint, Quaternion.identity);
        string printme = Quaternion.FromToRotation(GameObject.FindGameObjectWithTag("Planet").transform.position,spawnPoint).ToString();
        print(printme);//GameObject.FindGameObjectWithTag("Planet").transform.position.ToString());
        //print(printme);
        //print(spawnPoint.ToString());
        Vector3 kappa = new Vector3(1, 0, 0);
        Vector3 pozycja = new Vector3(asteroid.transform.position.x, asteroid.transform.position.y, 0);
        kat = Vector3.Angle(kappa,pozycja);
        if (pozycja.y < 0)
        {
            kat = -kat;
        }
        print(kat);
        asteroid.transform.Rotate(Vector3.forward, kat+90);
        //asteroid.transform.SetPositionAndRotation(asteroid.transform.position,Quaternion.FromToRotation(asteroid.transform.position, GameObject.FindGameObjectWithTag("Planet").transform.position));

    }

    // Update is called once per frame
    void Update () {
        if (Time.time > nextActionTime)
        {
            
            
            nextActionTime += period;
            spawnTime *= 0.75f;
            InvokeRepeating("addEnemy", 0,spawnTime);
      
            // execute block of code here
        }
    }
}
