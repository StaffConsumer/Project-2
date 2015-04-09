using UnityEngine;
using System.Collections;

public class PickUpItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		GameObject obj = col.gameObject;
		if(obj.tag == "GunPowerUp")
		{
			Destroy(obj);
			this.GetComponent<ShootGun>().hasGun = true;
		}
	}
}
