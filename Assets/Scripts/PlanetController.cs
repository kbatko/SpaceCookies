using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetController : MonoBehaviour {

    private SpriteRenderer planetRenderer;

	// Use this for initialization
	void Start () {
        planetRenderer = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public float GetPlanetSize ()
    {

        return planetRenderer.size[0];
    }
}
