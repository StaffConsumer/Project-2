using UnityEngine;
using System.Collections;

public class ShootGun : MonoBehaviour {

	[HideInInspector]
	public bool hasGun = false;
	public Rigidbody bullet;
	public float speed;
	public Transform spawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(hasGun)
		{
			if(Input.GetButtonDown("Fire1"))
			{
				Rigidbody InstantiateBullet = Instantiate(bullet, spawn.position,spawn.rotation) as Rigidbody;

				InstantiateBullet.velocity = spawn.TransformDirection(new Vector3(0,0,speed));
			}
		}
	}
}
