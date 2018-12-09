﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {


    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<Animator>().enabled = true;
        
        Destroy(gameObject,0.5f);
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
    }
}
