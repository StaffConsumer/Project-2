using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public static int StartTimer = 3 * 60;
	public static bool GameStarted = false;
	public static bool Deleted = false;
	private int DeleteTimer = 60;
	[HideInInspector]
	public static int StartTimerR;

	public static int Seconds = 0;
	private static int GameTimer = 0;

	// Use this for initialization
	void Start () 
	{
		StartTimerR = StartTimer;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(StartTimer <= 0)
		{
			GameStarted = true;
			DeleteTimer--;

			if(DeleteTimer < 0)
			{
				Deleted = true;
			}

			GameTimer++;
			Seconds = (GameTimer / 60);
		}
		else
		{
			StartTimer--;
		}


	}
}
