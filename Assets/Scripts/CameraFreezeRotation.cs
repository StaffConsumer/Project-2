using UnityEngine;
using System.Collections;

public class CameraFreezeRotation : MonoBehaviour {
	Quaternion initialRot;
	// Use this for initialization
	void Start () {

		 initialRot = this.transform.rotation;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		this.transform.rotation = initialRot;

	}
}
