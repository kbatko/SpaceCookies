using UnityEngine;
using Random = System.Random;

public class PlayerController : MonoBehaviour
{
    public bool isAlive = true;

    public Vector3 scale = new Vector3(1, 3, 1);
    public float speed = 2.0f;
    
    GameObject planet;
    float planetRadius;
    private float rotationAngle = -(float) new Random().NextDouble();


    // Use this for initialization
    void Start()
    {
        rotationAngle = -(float)new Random().NextDouble();
        planet = GameObject.FindGameObjectWithTag("Planet");
        planetRadius = planet.GetComponent<CircleCollider2D>().radius;
        transform.localScale = scale;
    }

    private void Update()
    {
        Vector2 up = this.transform.position - planet.transform.position;
        transform.rotation = Quaternion.LookRotation(transform.position, up);
        
        if (this.tag == "Player1" && Input.GetButton("Player1Horizontal")) rotationAngle += Input.GetAxis("Player1Horizontal") * speed * Time.deltaTime;
        if (this.tag == "Player2" && Input.GetButton("Player2Horizontal")) rotationAngle += Input.GetAxis("Player2Horizontal") * speed * Time.deltaTime;
        if (this.tag == "Player3" && Input.GetButton("Player3Horizontal")) rotationAngle += Input.GetAxis("Player3Horizontal") * speed * Time.deltaTime;
        if (this.tag == "Player4" && Input.GetButton("Player4Horizontal")) rotationAngle += Input.GetAxis("Player4Horizontal") * speed * Time.deltaTime;

        float x = Mathf.Cos(rotationAngle) * planetRadius;
        float y = Mathf.Sin(rotationAngle) * planetRadius;
        float z = 1;
        transform.position = new Vector3(-x, y, z);
    }
}
