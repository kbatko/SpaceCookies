using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

	public Vector2 gravityFactor;
	private Rigidbody2D rb;
	private GameObject planet;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		planet = GameObject.FindGameObjectWithTag("Planet");
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 acceleration = planet.transform.position - this.transform.position;
		rb.AddForce(acceleration * rb.mass * gravityFactor); 
	}

	private void FixedUpdate()
	{
		throw new System.NotImplementedException();
	}
}
