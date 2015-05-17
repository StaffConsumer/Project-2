using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public static int StartTimer = 4 * 60;
	public static bool GameStarted = false;
	public static bool Deleted = false;

	private int DeleteTimer = 60;
	[HideInInspector]
	public static int StartTimerR;

	public static int Seconds = 0;
	private static int GameTimer = 0;
	public Camera CctvCamera;

	public bool Active = false;

	public AudioClip t_3;
	public AudioClip t_2;
	public AudioClip t_1;
	public AudioClip t_go;

	// Use this for initialization
	void Start () 
	{
		StartTimerR = StartTimer;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Active)
		{
			if(StartTimer <= 0 && !GameStarted)
			{
				//CctvCamera.enabled = false;
				GameStarted = true;
				Debug.Log("Game Started");
			}
			else if(StartTimer > 0)
			{
				StartTimer--;

				{
					//play 3
					AudioSource.PlayClipAtPoint(t_3, Camera.main.transform.position);
				}
				else if(StartTimer == 120)
				{
					AudioSource.PlayClipAtPoint(t_2, Camera.main.transform.position);
				}
				else if(StartTimer == 60)
				{
					AudioSource.PlayClipAtPoint(t_1, Camera.main.transform.position);
				}
				else if(StartTimer == 0)
				{
					AudioSource.PlayClipAtPoint(t_go, Camera.main.transform.position);
				}
			}

			if(GameStarted)
			{
				DeleteTimer--;
				
				if(DeleteTimer < 0)
				{
					Deleted = true;
				}
				
				GameTimer++;
			}
		}
	}
}
