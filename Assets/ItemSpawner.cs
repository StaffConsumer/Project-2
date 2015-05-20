using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemSpawner : MonoBehaviour {

	public List<GameObject> types;
	public int tim = 0;
	public int Frequency = 60 * 6;
	Random r;

	// Use this for initialization
	void Start () {
		r = new Random ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		tim++;

		if(tim % Frequency == 0)
		{
			int rr = Random.Range(0,types.Count);
			//spawn item
			Vector3 randPos = new Vector3(Random.Range(-12,5), 1, Random.Range(-15, 1));
			GameObject theG = (GameObject)GameObject.Instantiate(types[rr],randPos, Quaternion.identity);
		}
	}
}
