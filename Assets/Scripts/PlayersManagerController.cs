using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersManagerController : MonoBehaviour
{

	public GameObject[] players;
	public string winner;
	public int numberOfAlivePlayers;
	private GameObject gameOverScreen;
		
	// Use this for initialization
	void Start ()
	{
		gameOverScreen = GameObject.FindGameObjectWithTag("GameOverScreen");
//		gameOverScreen.GetComponent<Canvas>().enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		numberOfAlivePlayers = 0;
		foreach (var player in players)
		{
			if (player.GetComponent<PlayerController>().isAlive)
			{
				winner = player.tag;
				numberOfAlivePlayers++;
			}
		}
		
//		if (numberOfAlivePlayers == 0)  gameOverScreen.GetComponent<Canvas>().enabled = true;
	}
}
