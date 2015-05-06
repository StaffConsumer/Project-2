using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class ShootGun : MonoBehaviour {

	[HideInInspector]
	public bool hasGun = false;
	public Rigidbody bullet;
	public float speed;

	bool fire1;
	bool fire2;
	bool fire3;
	bool fire4;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(hasGun)
		{
			LocalUserControl lus = GetComponentInParent<LocalUserControl>();
			int pid = lus.PLAYERID;
			switch(pid)
			{
			case 1:
				fire1 = CrossPlatformInputManager.GetButtonDown("Fire1");
				if(fire1)
				{
					Rigidbody InstantiateBullet = Instantiate(bullet, this.transform.position,this.transform.rotation) as Rigidbody;
					
					InstantiateBullet.velocity = this.transform.TransformDirection(new Vector3(0,0,speed));
				}
				break;
			case 2:
				fire2 = CrossPlatformInputManager.GetButtonDown("Fire2");
				if(fire2)
				{
					Rigidbody InstantiateBullet = Instantiate(bullet, this.transform.position,this.transform.rotation) as Rigidbody;
					
					InstantiateBullet.velocity = this.transform.TransformDirection(new Vector3(0,0,speed));
				}
				break;
			case 3:
				fire3 = CrossPlatformInputManager.GetButtonDown("Fire3");
				if(fire3)
				{
					Rigidbody InstantiateBullet = Instantiate(bullet, this.transform.position,this.transform.rotation) as Rigidbody;
					
					InstantiateBullet.velocity = this.transform.TransformDirection(new Vector3(0,0,speed));
				}
				break;
			case 4:
				fire4 = CrossPlatformInputManager.GetButtonDown("Fire4");
				if(fire4)
				{
					Rigidbody InstantiateBullet = Instantiate(bullet, this.transform.position,this.transform.rotation) as Rigidbody;
					
					InstantiateBullet.velocity = this.transform.TransformDirection(new Vector3(0,0,speed));
				}
				break;
			}
		}
	}
}
