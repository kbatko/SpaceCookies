using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public Vector2 gravityFactor;
	public Vector2 direction = new Vector2(-1,0);
	public float speed = 10.0f;
	
	private Rigidbody2D rb;
	private GameObject planet;
	
	float rotationCounter = 0;
	public float radius;
	public float rotation;


	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		planet = GameObject.FindGameObjectWithTag("Planet");
		radius = planet.GetComponent<CircleCollider2D>().radius;
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void FixedUpdate()
	{
		// gravity
		Vector2 acceleration = planet.transform.position - this.transform.position;
//		rb.AddForce(acceleration * rb.mass * gravityFactor); 
//		// rotation
		rotation = Vector2.Dot(direction.normalized, acceleration.normalized);
//		this.transform.Rotate(new Vector3(0, 0, (float)Math.Round(rotation, 1)));
		//steering
//		float translation = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
//		transform.Translate(0, translation, 0);

		rotationCounter += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		float x = Mathf.Cos (rotationCounter) * radius;
		float y = Mathf.Sin (rotationCounter) * radius;
		float z = 0;
		transform.position = new Vector3(-x, -y, z);
		transform.Rotate(new Vector3(0, 0, rotation));
	}
}
