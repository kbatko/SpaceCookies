using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class PlayerController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
    }

    //health
    public bool isAlive = true;

    public Vector2 direction = new Vector2(-1, 0);
    public Vector3 scale = new Vector3(1, 3, 1);
    public float speed = 2.0f;
    public float radius;

    private Rigidbody2D rb;
    private GameObject planet;

    float rotationCounter = 0;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        planet = GameObject.FindGameObjectWithTag("Planet");
        radius = planet.GetComponent<CircleCollider2D>().radius;
        transform.localScale = scale;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 up = this.transform.position - planet.transform.position;
        transform.rotation = Quaternion.LookRotation(transform.position, up);
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            rotationCounter += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        }
        float x = Mathf.Cos(rotationCounter) * radius;
        float y = Mathf.Sin(rotationCounter) * radius;
        float z = 1;
        transform.position = new Vector3(-x, -y, z);

    }
}
