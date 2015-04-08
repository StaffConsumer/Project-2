using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class PhaseIn : MonoBehaviour {

	bool oldGameStart = false;
	public Transform landPos;
	public float Smooth = .07f;
	public GameObject spotlight;

	// Use this for initialization
	void Start () 
	{
	
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
			GameObject.Destroy(spotlight);
			this.enabled = false;
		}
		else if(!Spawner.GameStarted)
		{
			//bring down
			float rat = (float)Spawner.StartTimer / Spawner.StartTimerR;
			this.transform.position = Vector3.Slerp (this.transform.position, landPos.position, Smooth);
		}

		oldGameStart = Spawner.GameStarted;
	}
}
