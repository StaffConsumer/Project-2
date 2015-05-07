using UnityEngine;
using System.Collections;

public class PickUpItem : MonoBehaviour {

	public GameObject spawn;
	public GameObject[] Items;

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
			spawn.GetComponent<ShootGun>().hasGun = true;
			spawn.GetComponent<ThrowBomb>().hasBomb = false;
			Items[0].SetActive(true);
			Items[1].SetActive(false);
		}
		if(obj.tag == "BombPowerUp")
		{
			Destroy(obj);
			spawn.GetComponent<ThrowBomb>().hasBomb = true;
			spawn.GetComponent<ShootGun>().hasGun = false;
			Items[0].SetActive(false);
			Items[1].SetActive(true);
		}
	}
}
