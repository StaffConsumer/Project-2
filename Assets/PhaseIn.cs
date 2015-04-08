using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;
using UnityStandardAssets.ImageEffects;

public class PhaseIn : MonoBehaviour {

	bool oldGameStart = false;
	public Transform landPos;
	public float Smooth = .07f;
	public GameObject spotlight;
	//public Camera cam;

	//int initIt;
	// Use this for initialization
	void Start () 
	{
		//initIt = cam.GetComponent<Blur> ().iterations;
	}
	
	// Update is called once per frame
	void Update () 
	{	
		//if the game just started
		if(Spawner.GameStarted && !oldGameStart)
		{
			//do nothing
			this.gameObject.GetComponent<Rigidbody>().useGravity = true;
			this.gameObject.GetComponent<ThirdPersonUserControl>().enabled = true;
			//cam.GetComponent<Blur>().enabled = false;
			GameObject.Destroy(spotlight);
			this.enabled = false;
		}
		else if(!Spawner.GameStarted)
		{
			//bring down
			float rat = (float)Spawner.StartTimer / Spawner.StartTimerR;
			this.transform.position = Vector3.Slerp (this.transform.position, landPos.position, Smooth);

			//Blur b = cam.GetComponent<Blur>();
			//float t = Mathf.Lerp(0, initIt, rat);
			//Debug.Log(b.iterations);
			//b.iterations = (int)t;
		}

		oldGameStart = Spawner.GameStarted;
	}
}
