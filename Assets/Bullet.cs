using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public int ID = 1;

	// Use this for initialization
	void Start () 
	{
	
	}

	void OnCollisionEnter(Collision c)
	{
		if(c.gameObject.tag.Equals("Player"))
		{
			if(c.gameObject.GetComponent<LocalUserControl>().PLAYERID != ID)
			{
				c.gameObject.GetComponent<Rigidbody>().velocity += this.GetComponent<Rigidbody>().velocity;
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
