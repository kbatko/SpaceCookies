using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionController : MonoBehaviour
{

	public Vector2 gravityFactor = new Vector2(1,1);
	public Vector2 direction = new Vector2(-1,0);
	
	private Rigidbody2D rb;
	private GameObject planet;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		planet = GameObject.FindGameObjectWithTag("Planet");
	}

	private void FixedUpdate()
	{
		// gravity
		Vector2 acceleration = planet.transform.position - this.transform.position;
		rb.AddForce(acceleration * rb.mass * gravityFactor); 
		// rotation
		//float rotation = Vector2.Dot(direction.normalized, acceleration.normalized);
		//this.transform.Rotate(new Vector3(0, 0, (float)Math.Round(rotation, 1)));
	}
}
