using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.ImageEffects;
using System;

public class PhaseIn : MonoBehaviour {

	bool oldGameStart = false;
	public float Smooth = .07f;
	public GameObject spotlight;
	[HideInInspector]
	public Vector3 init;
	//public Camera cam;

	//int initIt;
	// Use this for initialization
	void Start () 
	{
		//initIt = cam.GetComponent<Blur> ().iterations;
		init = GetComponent<Transform> ().position;
	}
	
	// Update is called once per frame
	void Update () 
	{	
		//if the game just started
		if(Spawner.GameStarted && !oldGameStart)
		{
			//do nothing
			this.gameObject.GetComponent<Rigidbody>().useGravity = true;

			try
			{
				this.gameObject.GetComponent<ThirdPersonUserControl>().enabled = true;

			}
			catch(NullReferenceException e)
			{

			}

			//cam.GetComponent<Blur>().enabled = false;
			GameObject.Destroy(spotlight);
			GetComponent<LocalUserControl>().enabled = true;
			this.enabled = false;
		}
		else if(!Spawner.GameStarted)
		{
			//bring down
			float rat = (float)Spawner.StartTimer / Spawner.StartTimerR;
			this.transform.position = Vector3.Slerp (this.transform.position, init - Vector3.up * 8.6f, Smooth);

			//Blur b = cam.GetComponent<Blur>();
			//float t = Mathf.Lerp(0, initIt, rat);
			//Debug.Log(b.iterations);
			//b.iterations = (int)t;
		}

		oldGameStart = Spawner.GameStarted;
	}
}
