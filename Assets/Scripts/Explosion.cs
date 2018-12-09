using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
         Destroy(gameObject);
    }

    public Vector2 velo;
    private Rigidbody2D rb;
    public float length;

    // Use this for initialization
    void Start () {
        rb = this.GetComponent<Rigidbody2D>();
        velo = rb.velocity;
	}
	
	// Update is called once per frame
	void Update () {
        if (this.GetComponent<Rigidbody2D>().velocity.magnitude < 0)
        {
            Destroy(gameObject);
        }
        length = this.GetComponent<Rigidbody2D>().velocity.magnitude;
    }
}
