using UnityEngine;
using System.Collections;

public class DeleteBlock : MonoBehaviour {

	public Camera Default;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		GameObject obj = col.gameObject;
		if(obj.tag == "Cube")
		{
			Destroy (obj);
		}
		else if(obj.tag == "Player")
		{
			Default.enabled = true;
			Destroy(obj);
		}
	}
}
