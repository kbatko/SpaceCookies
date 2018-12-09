using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    public int hit_player = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<Animator>().enabled = true;
        if (collision.gameObject.tag == "Player")
        {
            //dziala
            Destroy(collision.gameObject);
        }
        else
        {
            Destroy(gameObject, 0.5f);
        }
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
    }
}
