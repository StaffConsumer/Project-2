using UnityEngine;
using System.Collections;

public class Winner : MonoBehaviour {
	int count;
	GameObject[] Players;
	int timer = 1 * 60;
	public GameObject GameOverCanvas;
	public GameObject WinnerCanvas;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Players = GameObject.FindGameObjectsWithTag ("Player");
		count = Players.Length;

		if(count == 1)
		{
			timer--;
			if(timer == 0 && count == 0)
			{
				GameOverCanvas.SetActive(true);
			}
			else if(timer == 0)
			{
				WinnerCanvas.SetActive(true);
			}
			
		}
		else if(count == 0)
		{
			GameOverCanvas.SetActive(true);
		}
	}
}
